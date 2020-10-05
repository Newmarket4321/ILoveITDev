using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using System.Drawing.Printing;
using System.IO;

namespace I_IT
{
    public partial class KnowledgeGarden : Form
    {
        static SqlConnection con = new SqlConnection("Server=172.16.0.34; Database=KnowledgeGarden; User Id=DATS; password=SQL2008@r2");
        int checkPrint;

        bool changes = false;

        public KnowledgeGarden()
        {
            InitializeComponent();
            SetupProgram();
        }

        public KnowledgeGarden(int start)
        {
            InitializeComponent();
            SetupProgram();

            TreeNode node = null;

            for (int i = 0; i < nodeList.Nodes.Count && node == null; i++)
            {
                TreeNode result = findNode(nodeList.Nodes[i], start.ToString());
                if (result != null)
                    node = result;
            }

            nodeList.SelectedNode = node;
        }

        private void SetupProgram()
        {
            updateDataLabel();

            string strSql = "select ID, [Description] from Nodes where Deleted='False' and parentID=-1 order by [Description]";
            SqlCommand com = new SqlCommand(strSql, con);
            SqlDataAdapter sda = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            int numNodes = dt.Rows.Count;

            for (int i = 0; i < numNodes; i++)
            {
                string ID = dt.Rows[i][0].ToString();
                string description = dt.Rows[i][1].ToString();

                TreeNode r = new TreeNode(description, getChildren(ID));
                r.Tag = ID;
                nodeList.Nodes.Add(r);
            }
        }

        private void updateDataLabel()
        {
            try
            {
                data.Text = "nodeID " + nodeList.SelectedNode.Tag;
            }
            catch
            {
                data.Text = "";
            }
        }

        private TreeNode[] getChildren(string IDx)
        {
            string strSql = "select ID, [Description] from Nodes where Deleted='False' and parentID=@ID order by [Description]";
            SqlCommand com = new SqlCommand(strSql, con);
            com.Parameters.Add("@ID", SqlDbType.VarChar).Value = IDx;
            SqlDataAdapter sda = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            int numNodes = dt.Rows.Count;

            TreeNode[] r = new TreeNode[numNodes];

            for (int i = 0; i < numNodes; i++)
            {
                string ID = dt.Rows[i][0].ToString();
                string description = dt.Rows[i][1].ToString();

                r[i] = new TreeNode(description, getChildren(ID));
                r[i].Tag = ID;
            }

            return r;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1_Backup.ActiveForm.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Version 1.01");
        }

        private void nodeList_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode s = ((TreeView)sender).SelectedNode;

            string strSql = "select Message from Nodes where Deleted='False' and ID=@ID";
            SqlCommand com = new SqlCommand(strSql, con);
            com.Parameters.Add("@ID", SqlDbType.VarChar).Value = s.Tag;
            SqlDataAdapter sda = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                //title.Text = dt.Rows[0][0].ToString();
                message.Rtf = dt.Rows[0][0].ToString();
                enableDocumentScreen();

                message.ReadOnly = !hasPermission(nodeList.SelectedNode);
            }
            else
            {
                disableDocumentScreen();
            }

            changes = false;
            updateDataLabel();
        }

        private void enableDocumentScreen()
        {
            //title.Enabled = true;
            message.Enabled = true;
            //newDocument.Enabled = false;
            //deleteDocument.Enabled = true;
        }

        private void disableDocumentScreen()
        {
            //title.Enabled = false;
            message.Enabled = false;
            //newDocument.Enabled = true;
            //deleteDocument.Enabled = false;
            //title.Text = "";
            message.Text = "";
        }

        private void newRootNode_Click(object sender, EventArgs e)
        {
            TreeNode parent = nodeList.SelectedNode.Parent;
            TreeNode newNode = new TreeNode("New Node");

            if (!hasPermission(parent))
                MessageBox.Show("You don't have permission to create nodes here.");
            else
            {
                if (parent != null)
                    nodeList.SelectedNode.Parent.Nodes.Add(newNode);
                else
                    nodeList.Nodes.Add(newNode);

                string strSql = "insert into nodes values (@PID, @DESC, 'false', '', '1')";
                SqlCommand com = new SqlCommand(strSql, con);
                com.Parameters.Add("@PID", SqlDbType.VarChar).Value = parent == null ? -1 : parent.Tag;
                com.Parameters.Add("@DESC", SqlDbType.VarChar).Value = newNode.Text;
                SqlDataAdapter sda = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                strSql = "select max(id) from nodes";
                com = new SqlCommand(strSql, con);
                sda = new SqlDataAdapter(com);
                dt = new DataTable();
                sda.Fill(dt);

                newNode.Tag = dt.Rows[0][0].ToString();
            }
        }

        private void editNodeName_Click(object sender, EventArgs e)
        {
            nodeList.SelectedNode.BeginEdit();
        }

        private void nodeList_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            try
            {
                TreeNode node = e.Node;

                string strSql = "update nodes set [description]=@DESC where id=@ID";
                SqlCommand com = new SqlCommand(strSql, con);
                com.Parameters.Add("@ID", SqlDbType.VarChar).Value = e.Node.Tag;
                com.Parameters.Add("@DESC", SqlDbType.VarChar).Value = e.Label;
                SqlDataAdapter sda = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                sda.Fill(dt);
            }
            catch
            {
                //In case a label was in edit mode when being deleted.
            }
        }

        private void updateDocument()
        {
            if (message.Enabled)
            {
                string strSql = "update nodes set message=@MESSAGE where id=@NODEID";
                SqlCommand com = new SqlCommand(strSql, con);
                com.Parameters.Add("@MESSAGE", SqlDbType.VarChar).Value = message.Rtf;
                com.Parameters.Add("@NODEID", SqlDbType.VarChar).Value = nodeList.SelectedNode.Tag;
                SqlDataAdapter sda = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                sda.Fill(dt);
            }
        }

        private void message_KeyUp(object sender, KeyEventArgs e)
        {
            changes = true;
        }

        private bool hasPermission(TreeNode node)
        {
            if (node == null)
                return false;

            ArrayList nodes = getAncestry(node, null);

            string nodeString = "";

            for (int i = 0; i < nodes.Count; i++)
            {
                if (i != 0)
                    nodeString += "or ";
                nodeString += "nodeID = " + ((TreeNode)nodes[i]).Tag + " ";
            }

            string strSql = "select * from admin where username=@USERNAME and (" + nodeString + ")";
            SqlCommand com = new SqlCommand(strSql, con);
            com.Parameters.Add("@USERNAME", SqlDbType.VarChar).Value = Environment.UserName;
            SqlDataAdapter sda = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count > 0)
                return true;
            return false;
        }

        private void deleteNode_Click(object sender, EventArgs e)
        {
            if (!hasPermission(nodeList.SelectedNode))
            {
                MessageBox.Show("You don't have permission to delete the \"" + nodeList.SelectedNode.Text + "\" node (id " + nodeList.SelectedNode.Tag + ").");
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete \"" + nodeList.SelectedNode.Text + "\"?", "Are you sure?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string strSql = "update nodes set deleted='true' where id=@NODEID";
                    SqlCommand com = new SqlCommand(strSql, con);
                    com.Parameters.Add("@NODEID", SqlDbType.VarChar).Value = nodeList.SelectedNode.Tag;
                    SqlDataAdapter sda = new SqlDataAdapter(com);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    nodeList.SelectedNode.EndEdit(true);
                    nodeList.SelectedNode.Remove();
                }
            }
        }

        private void newChildNode_Click(object sender, EventArgs e)
        {
            TreeNode parent = nodeList.SelectedNode;
            TreeNode newNode = new TreeNode("New Node");

            if (!hasPermission(parent))
                MessageBox.Show("You don't have permission to create nodes within the \"" + nodeList.SelectedNode.Text + "\" node (id " + nodeList.SelectedNode.Tag + ").");
            else
            {
                if (parent != null)
                    parent.Nodes.Add(newNode);
                else
                    nodeList.Nodes.Add(newNode);

                string strSql = "insert into nodes values (@PID, @DESC, 'false', '', '1')";
                SqlCommand com = new SqlCommand(strSql, con);
                com.Parameters.Add("@PID", SqlDbType.VarChar).Value = parent == null ? -1 : parent.Tag;
                com.Parameters.Add("@DESC", SqlDbType.VarChar).Value = newNode.Text;
                SqlDataAdapter sda = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                strSql = "select max(id) from nodes";
                com = new SqlCommand(strSql, con);
                sda = new SqlDataAdapter(com);
                dt = new DataTable();
                sda.Fill(dt);

                newNode.Tag = dt.Rows[0][0].ToString();
            }
        }

        //private void search()
        //{
        //    searchNotification.Visible = true;
        //    toolStrip1.Update();

        //    string strSql = "select top(1) id from nodes where [message] like @QUERY"; // or [description] like @QUERY";
        //    SqlCommand com = new SqlCommand(strSql, con);
        //    com.Parameters.Add("@QUERY", SqlDbType.VarChar).Value = "%" + searchBox.Text + "%";
        //    SqlDataAdapter sda = new SqlDataAdapter(com);
        //    DataTable dt = new DataTable();
        //    sda.Fill(dt);

        //    string test = "";

        //    if (searchBox.Text == "")
        //    {
        //        disableDocumentScreen();
        //        nodeList.SelectedNode = null;
        //    }
        //    else if (dt.Rows.Count > 0)
        //    {
        //        string ID = dt.Rows[0][0].ToString();

        //        TreeNode node = null;

        //        for (int i = 0; i < nodeList.Nodes.Count && node == null; i++)
        //        {
        //            TreeNode result = findNode(nodeList.Nodes[i], ID);
        //            if (result != null)
        //                node = result;
        //        }

        //        nodeList.SelectedNode = node;
        //    }
        //    else
        //    {
        //        disableDocumentScreen();
        //    }

        //    searchNotification.Visible = false;
        //    toolStrip1.Update();
        //}

        private TreeNode findNode(TreeNode start, string ID)
        {
            if (start.Tag.ToString() == ID)
                return start;
            else
            {
                for (int i = 0; i < start.Nodes.Count; i++)
                {
                    TreeNode result = findNode(start.Nodes[i], ID);
                    if (result != null)
                        return result;
                }
            }

            return null;
        }

        private void searchBox_Enter(object sender, EventArgs e)
        {
            //searchBox.Text = "";
        }

        private void refreshDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not yet implemented.");
        }

        private void advancedSearch_Click(object sender, EventArgs e)
        {
            AdvancedSearch form = new AdvancedSearch();
            form.ShowDialog();

            if (form.value != 0)
            {
                TreeNode node = null;

                for (int i = 0; i < nodeList.Nodes.Count && node == null; i++)
                {
                    TreeNode result = findNode(nodeList.Nodes[i], form.getValue().ToString());
                    if (result != null)
                        node = result;
                }

                nodeList.SelectedNode = node;

                //HighlightText(message, "tree", Color.Red);
            }
        }

        public void HighlightText(RichTextBox myRtb, string word, Color color)
        {
            int s_start = myRtb.SelectionStart, startIndex = 0, index;

            while ((index = myRtb.Text.IndexOf(word, startIndex)) != -1)
            {
                myRtb.Select(index, word.Length);
                myRtb.SelectionBackColor = color;

                startIndex = index + word.Length;
            }

            myRtb.SelectionStart = s_start;
            myRtb.SelectionLength = 0;
            myRtb.SelectionBackColor = Color.Black;
        }

        private void searchBox_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //    search();
        }

        private ArrayList getAncestry(TreeNode x, ArrayList progress)
        {
            ArrayList p;

            if (x == null)
                return progress;

            if (progress == null)
                p = new ArrayList();
            else
                p = progress;

            p.Add(x);

            return getAncestry(x.Parent, p);
        }

        private void moveDown_Click(object sender, EventArgs e)
        {
            if (!hasPermission(nodeList.SelectedNode))
            {

            }
            else
            {
                string strSql = "select sortorder from nodes where id=@ID";
                SqlCommand com = new SqlCommand(strSql, con);
                com.Parameters.Add("@ID", SqlDbType.Int).Value = nodeList.SelectedNode.Tag;
                SqlDataAdapter sda = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                strSql = "select sortorder from nodes where id=@ID";
                com = new SqlCommand(strSql, con);
                com.Parameters.Add("@ID", SqlDbType.Int).Value = nodeList.SelectedNode.Tag;
                sda = new SqlDataAdapter(com);
                dt = new DataTable();
                sda.Fill(dt);
            }
        }

        private void moveNode_Click(object sender, EventArgs e)
        {
            if(hasPermission(nodeList.SelectedNode))
            {
                MoveNode form = new MoveNode(nodeList.SelectedNode.Text);
                form.ShowDialog();

                if (form.value != 0)
                {

                    //This is what we're moving
                    TreeNode nodeMoving = nodeList.SelectedNode;

                    //Finding where we're moving it
                    TreeNode node = null;

                    for (int i = 0; i < nodeList.Nodes.Count && node == null; i++)
                    {
                        TreeNode result = findNode(nodeList.Nodes[i], form.getValue().ToString());
                        if (result != null)
                            node = result;
                    }

                    nodeList.SelectedNode = node;

                    //If we successfully found the target move location
                    if (nodeList.SelectedNode != null && nodeList.SelectedNode.Tag.ToString() == form.getValue().ToString())
                    {
                        //If we have permission at the target move location
                        if (hasPermission(nodeList.SelectedNode))
                        {
                            string strSql = "update nodes set parentid=@PID where id=@ID";
                            SqlCommand com = new SqlCommand(strSql, con);
                            com.Parameters.Add("@PID", SqlDbType.Int).Value = nodeList.SelectedNode.Tag;
                            com.Parameters.Add("@ID", SqlDbType.Int).Value = nodeMoving.Tag;
                            SqlDataAdapter sda = new SqlDataAdapter(com);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);

                            nodeMoving.Parent.Nodes.Remove(nodeMoving);
                            nodeList.SelectedNode.Nodes.Add(nodeMoving);
                        }
                        else
                        {
                            MessageBox.Show("You don't have permission to put child nodes under \"" + nodeList.SelectedNode.Text + "\" node (id " + nodeList.SelectedNode.Tag + ").");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Node ID " + form.getValue().ToString() + " not found.");
                    }
                }
            }
            else
            {
                MessageBox.Show("You don't have permission to move the \"" + nodeList.SelectedNode.Text + "\" node (id " + nodeList.SelectedNode.Tag + ").");
            }
        }

        private void nodeList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                editNodeName_Click(null, null);
            else if (e.Control && e.KeyCode == Keys.P)
                toolStripButton5_Click(null, null);
        }

        private void message_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void nodeList_BeforeLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            if (!hasPermission(nodeList.SelectedNode))
            {
                MessageBox.Show("You don't have permission to edit the \"" + nodeList.SelectedNode.Text + "\" node (id " + nodeList.SelectedNode.Tag + ").");
                nodeList.SelectedNode.EndEdit(true);
            }
        }
        
        //Printing
        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            PrintDocument documentToPrint = new PrintDocument();
            printDialog.Document = documentToPrint;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                StringReader reader = new StringReader(message.Rtf);
                documentToPrint.PrintPage += new PrintPageEventHandler(printerHandler);
                documentToPrint.Print();
                checkPrint = 0;
            }
        }

        private void printerHandler(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Print the content of RichTextBox. Store the last character printed.
            checkPrint = message.getRTFBox().Print(checkPrint, message.getRTFBox().TextLength, e);

            // Check for more pages
            if (checkPrint < message.getRTFBox().TextLength)
                e.HasMorePages = true;
            else
                e.HasMorePages = false;

            //StringReader reader = new StringReader(message.Text);
            //float LinesPerPage = 0;
            //float YPosition = 0;
            //int Count = 0;
            //float LeftMargin = e.MarginBounds.Left;
            //float TopMargin = e.MarginBounds.Top;
            //string Line = null;
            //Font PrintFont = this.message.Font;
            //SolidBrush PrintBrush = new SolidBrush(Color.Black);

            //LinesPerPage = e.MarginBounds.Height / PrintFont.GetHeight(e.Graphics);
            //RectangleF rect = new RectangleF(e.MarginBounds.Left, e.MarginBounds.Top, e.MarginBounds.Right - e.MarginBounds.Left, e.MarginBounds.Bottom - e.MarginBounds.Top);

            //Line = reader.ReadToEnd();
            //e.Graphics.DrawString(Line, PrintFont, PrintBrush, rect, new StringFormat());
            //e.HasMorePages = false;
            //PrintBrush.Dispose();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButton5_Click(null, null);
        }

        private void message_TextChanged()
        {
            changes = true;
        }

        private void message_RTFBoxLinkClicked(LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }

        private void message_RTFBoxPrintRequested()
        {
            toolStripButton5_Click(null, null);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(message.getRTFBox().SelectedRtf, TextDataFormat.Rtf);
        }

        private void message_Click(object sender, EventArgs e)
        {
            
        }

        private void message_RTFBoxRightClicked()
        {
            
        }

        private void message_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void message_RTFBoxRightMouseUp(MouseEventArgs e)
        {
            contextMenuStrip1.Show(this.Location.X + splitContainer1.Panel2.Left + e.Location.X+30, this.Location.Y + splitContainer1.Panel2.Top + e.Location.Y+90);
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            message.getRTFBox().Cut();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            message.getRTFBox().Paste();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (changes)
            {
                //if (MessageBox.Show("Before closing, would you like to save your changes to " + nodeList.SelectedNode.Text + "?", "Save Changes?", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                //{
                    updateDocument();
                //}
            }
        }

        private void nodeList_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            if (changes)
            {
                //if (MessageBox.Show("Would you like to save your changes to " + nodeList.SelectedNode.Text + "?", "Save Changes?", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                //{
                    updateDocument();
                //}
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }
    }
}

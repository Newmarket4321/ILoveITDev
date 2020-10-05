using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I_IT
{
    public partial class ChooseFields : Form
    {
        int id;

        public ChooseFields(int idIn)
        {
            InitializeComponent();

            id = idIn;

            DataTable dt = SQL.Run("use statmetpod; select code, description from fields order by description");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                checkedListBox1.Items.Add(dt.Rows[i]["description"].ToString());

                if (SQL.Run("use statmetpod; select * from topicfields where topicid = @ID and field = @CODE", id, dt.Rows[i]["code"].ToString()).Rows.Count > 0)
                    checkedListBox1.SetItemChecked(i, true);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQL.Run("use statmetpod; delete from topicfields where topicid = @ID", id);

            for(int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                string code = SQL.RunString("use statmetpod; select code from fields where description = @DESC", checkedListBox1.CheckedItems[i].ToString());

                SQL.Run("use statmetpod; insert into topicfields values (@ID, @CODE)", id, code);
            }

            Close();
        }
    }
}

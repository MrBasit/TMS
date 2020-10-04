using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsoleApplication3;

namespace Technomide_Corporation
{
    public partial class Add_Update_Withdrawal_Form : Form
    {
        Withdrawl_form withdrawal;

        Model_Withdrawal cls_withdrawal = new Model_Withdrawal();

        public Add_Update_Withdrawal_Form(Withdrawl_form with)
        {
            InitializeComponent();
            withdrawal = with;
        }

        private void btn_Add_Withdrawal_Click(object sender, EventArgs e)
        {
            cls_withdrawal.ProcInsertWithdrawal(txt_withdrawal_name.Text, txt_withdrawal_amount.Text, txt_withdrawal_date.Text, txt_withdrawal_note.Text);
            withdrawal.Refresh();
        }

        private void btn_Update_Withdrawal_Click(object sender, EventArgs e)
        {
            cls_withdrawal.ProcUpdateWithdrawal(Convert.ToInt32(txt_withdrawal_id.Text), txt_withdrawal_name.Text, txt_withdrawal_amount.Text, txt_withdrawal_date.Text, txt_withdrawal_note.Text);
            withdrawal.Refresh();
        }

        private void Add_Update_Withdrawal_Form_Load(object sender, EventArgs e)
        {

        }
    }
}

using System.Windows.Forms;

namespace Accounting.Utility
{
    public static class AppTools
    {
        public static void DeActivate(DataGridView dgv = null, params ToolStripButton[] buttons)
        {
            foreach (var button in buttons)
            {
                switch (dgv.RowCount)
                {
                    case 0:
                        button.Enabled = false;
                        break;
                    default:
                        button.Enabled = true;
                        break;
                }
            }
        }

        public static void DeActivate(params ToolStripButton[] buttons)
        {
            foreach (var button in buttons)
                button.Enabled = false;
        }

        public static void Activate(params ToolStripButton[] buttons)
        {
            foreach (var button in buttons)
                button.Enabled = true;
        }

        public static bool ThereAreRows(this DataGridView dgv)
        {
            return dgv.RowCount > 0;
        }

        public static void Message(byte type)
        {
            switch (type)
            {
                case Statuses.Success:
                    RtlMessageBox.Show("عملیات با موفقیت انجام شد", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    break;
                case Statuses.Error:
                    RtlMessageBox.Show("عملیات با موفقیت انجام نشد، لطفا مجددا تلاش کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case Statuses.DuplicatedRecord:
                    RtlMessageBox.Show("امکان ثبت رکورد تکراری وجود ندارد", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case Statuses.UserNotFound:
                    RtlMessageBox.Show("کاربری یافت نشد، لطفا مجددا تلاش کنید", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case Statuses.PasswordNotMatch:
                    RtlMessageBox.Show("رمز عبور با تکرار آن یکسان نیست", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case Statuses.RequiredCombobox:
                    RtlMessageBox.Show("لطفا یک مقدار از کامبوباکس را انتخاب کنید", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case Statuses.UnauthorizedEntry:
                    RtlMessageBox.Show("همکار عزیز ، ورود برای شما غیر فعال شده است", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case Statuses.CurrentPasswordIsNotCorrect:
                    RtlMessageBox.Show("رمز عبور فعلی صحیح نمی‌باشد", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case Statuses.AdminIsNotBlocked:
                    RtlMessageBox.Show("مدیر سیستم نمی‌تواند بلاک شود", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case Statuses.SelectNewPassword:
                    RtlMessageBox.Show("لطفا رمز عبور جدیدی را انتخاب کنید", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
        }

        public static bool TwoChoiceWarningMessage()
        {
            return RtlMessageBox.Show("آیا از انجام این عملیات اطمینان دارید؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        public static long GetId(this DataGridView dgv)
        {
            return (long)dgv.CurrentRow.Cells["col_Id"].Value;
        }

        public static byte GetRole(this DataGridView dgv)
        {
            return (byte)dgv.CurrentRow.Cells["col_Role"].Value;
        }

        public static bool GetStatus(this DataGridView dgv)
        {
            return (bool)dgv.CurrentRow.Cells["col_Status"].Value;
        }

        public static void OnlyNumbers(this KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        public static void EnglishLettersOnly(this KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'آ' && e.KeyChar <= 'ی')
                e.Handled = true;
        }

        public static void PriceFormat(params TextBox[] textBoxs)
        {
            double number;

            foreach (var textBox in textBoxs)
            {
                if (double.TryParse(textBox.Text, out number))
                {
                    textBox.Text = string.Format("{0:N0}", number);
                    textBox.SelectionStart = textBox.Text.Length;
                }
            }
        }
    }
}
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace C_sharp_Inheritance
{
    class TextBoxNumbersOnly : TextBox
    {
        private TextBox textBox1;
        bool numbersOnly;

        [Browsable(true)]
        [Category("Custom Behavior")]
        [Description("Allows only numbers in the TextBox. If it's set to TRUE, Multiline property can be FALSE only!")]
        [DisplayName("NumbersOnly")]
        public bool NumbersOnly
        {
            get { return this.numbersOnly; }
            set
            {
                this.numbersOnly = value;
                if (value)
                {
                    this.KeyPress += new KeyPressEventHandler(TextBoxNumersOnly_KeyPress);
                    base.Multiline = false;

                    Decimal temp = 0;
                    if (!Decimal.TryParse(this.Text, out temp)) this.Text = "0";//TextBox, NumbersOnly özelliğini etkinleştirmeden önce yalnızca rakam içermiyorsa, '0' metnine sahip olacaktır
                }
                else
                {
                    this.KeyPress -= new KeyPressEventHandler(TextBoxNumersOnly_KeyPress);
                }
            }
        }

        public override string Text
        {
            get { return base.Text; }
            set
            {
                if (!this.numbersOnly) base.Text = value;
                else
                {
                    Decimal temp = 0;
                    if (!Decimal.TryParse(value, out temp)) base.Text = "";
                    else base.Text = value;
                }
            }
        }

        public override bool Multiline
        {
            get { return base.Multiline; }
            set
            {
                if (!this.numbersOnly) base.Multiline = value;
            }
        }

        public TextBoxNumbersOnly()
        {
            NumbersOnly = true;
        }

        protected virtual void TextBoxNumersOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))//check if it's the first '.'
            {
                e.Handled = true;//if no, ignore it
            }
        }


        public event EventHandler<NumberKeyPressEventArgs> NumberPressed;
        protected virtual void OnNumberPressed(NumberKeyPressEventArgs e)
        {
            EventHandler<NumberKeyPressEventArgs> handler = NumberPressed;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.ResumeLayout(false);

        }
    }

    public class NumberKeyPressEventArgs : KeyEventArgs
    {
        private Keys myKeys;
        public Keys MyKeys
        {
            get { return myKeys; }
        }
        public NumberKeyPressEventArgs(Keys keyData) : base(keyData)
        {
            this.myKeys = keyData;
        }
    }
}
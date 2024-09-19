using System.Text;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace conversionesMSARFGLLJRAC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TBX_HEXA_TextChanged(object sender, EventArgs e)
        {


        }

        private void TXB_BIN_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTTN_CONV_Click(object sender, EventArgs e)
        {
            if (float.TryParse(TBX_DEC.Text, out float decimalValue))
            {
               
                ushort halfPrecision = ConvertToHalfPrecision(decimalValue);

                
                string hexValue = halfPrecision.ToString("X4");

                TXB_CM.Text = hexValue.ToUpper();
            }
            else
            {
                
                MessageBox.Show("Por favor, ingrese un número decimal válido.");
            }
        }

        private ushort ConvertToHalfPrecision(float value)
        {
           
            int bits = BitConverter.ToInt32(BitConverter.GetBytes(value), 0);

          
            int sign = (bits >> 31) & 0x01;
            int exponent = ((bits >> 23) & 0xFF) - 127;
            int mantissa = bits & 0x7FFFFF;

            if (exponent == 128) 
                return (ushort)((sign << 15) | 0x7C00 | (mantissa >> 13));
            if (exponent > 15) 
                return (ushort)((sign << 15) | 0x7C00);
            if (exponent < -24) 
            {
                int shift = -24 - exponent;
                if (shift >= 32)
                    return (ushort)(sign << 15);
                mantissa |= 0x800000;
                mantissa >>= shift;
                return (ushort)((sign << 15) | mantissa);
            }

            
            exponent += 15;
            if (exponent >= 0x1F) 
                return (ushort)((sign << 15) | 0x7C00);
            if (exponent < 0) 
            {
                return (ushort)(sign << 15);
            }

            return (ushort)((sign << 15) | (exponent << 10) | (mantissa >> 13));
        }
    }
}

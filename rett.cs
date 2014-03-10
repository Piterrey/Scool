private void buttonCalcola_Click(object sender, EventArgs e)
        {
            double A = Convert.ToDouble(textBoxA.Text);
            double B = Convert.ToDouble(textBoxB.Text);
            double N = Convert.ToDouble(textBoxN.Text);
            double width=(Math.Abs(B)-Math.Abs(A))/N;
            double height = 4;

            for (int i = 0; i < N; i++)
            {
                grpMain._drawRectangle(A,-5,width,height, Color.Green);
                A += width;
                height--;
            }
            
            
        }

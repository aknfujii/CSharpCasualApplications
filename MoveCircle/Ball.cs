using System.Drawing;
using System.Windows.Forms;

public class Ball
{
    public int pitch;

    private PictureBox pictureBox;
    private Bitmap canvas;
    private Brush brushColor;
    private int positionX;
    private int positionY;
    private int previousX;
    private int previousY;
    private int directionX;
    private int directionY;
    private int radius;
    private string kanji;
    private string fontName;

    public Ball(PictureBox pb,Bitmap cv,Brush cl,string st)
    {
        pictureBox = pb;
        canvas = cv;
        brushColor = cl;
        kanji = st;
        radius = 40;
        pitch = radius / 2;
        directionX=+1;
        directionY=+1;
        fontName="HG教科書体";
    }

    public void PutCircle(int x,int y)
    {
        positionX=x;
        positionY=y;

        using(Graphics g =Graphics.FromImage(canvas))
        {
            g.FillEllipse(brushColor,x,y,radius*2,radius*2);

            g.DrawString(kanji,new Font(fontName,radius),Brushes.Black,x+4,y+12,new StringFormat());

            pictureBox.Image=canvas;
        }
    }

    public void DeleteCircle()
    {
        if(previousX==0)
        {
            previousX=positionX;
        }
        if (previousY==0)
        {
            previousY=positionY;
        }

        using (Graphics g=Graphics.FromImage(canvas))
        {
            g.FillEllipse(Brushes.White,previousX,previousY,radius*2,radius*2);

            pictureBox.Image=canvas;
        }
    }

    public void Move()
    {
        DeleteCircle();

        int x=positionX+pitch*directionX;
        int y=positionY+pitch*directionY;  


        if (x>=pictureBox.Width - radius*2)
        {
            directionX=-1;
        }
        if(x<=0)
        {
            directionX=+1;
        }
        if(y>=pictureBox.Height-radius*2)
        {
           directionY=-1;
        }
        if (y<=0)
        {
        directionY=+1;
        }

        positionX=x+directionX;
        positionY=y+directionY;

        PutCircle(positionX,positionY);

        previousX=positionX;
        previousY=positionY;
    }
}




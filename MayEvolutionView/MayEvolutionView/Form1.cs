using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tao.OpenGl;
using Tao.FreeGlut;
using Tao.Platform.Windows;
using MayEvolutionModels;
namespace MayEvolutionView
{
    public partial class Form1 : Form, IView
    {
        public Form1()
        {
            InitializeComponent();
            AnT.InitializeContexts();
            Glut.glutInit();
            Glut.glutInitDisplayMode(Glut.GLUT_RGB | Glut.GLUT_DOUBLE | Glut.GLUT_DEPTH);

            // очитка окна 
            Gl.glClearColor(255, 255, 255, 1);

            // установка порта вывода в соотвествии с размерами элемента anT 
            Gl.glViewport(0, 0, AnT.Width, AnT.Height);


            // настройка проекции 
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            
            Gl.glLoadIdentity();
            Glu.gluPerspective(45, (float)AnT.Width / (float)AnT.Height, 0.1, 200);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();

            // настройка параметров OpenGL для визуализации 
            Gl.glEnable(Gl.GL_DEPTH_TEST);


            timer1 = new Timer();
            timer1.Interval = 500;
            timer1.Tick += NeedReDraw;
            timer1.Enabled = true;
        }
        public void NeedReDraw(object o, EventArgs e)
        {
            TryReDraw.Invoke(o, e);
        }
        public event EventHandler<EventArgs> TryReDraw;
        public void Clear()
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
        }
        public void Draw(IDrawable o)
        {
            //Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            
            Gl.glLoadIdentity();
            Gl.glColor3f(o.R, o.G, o.B);

            Gl.glPushMatrix();
            Gl.glTranslated(0, 0, -6);
            //Gl.glRotated(45, 1, 1, 0);

            // рисуем сферу с помощью библиотеки FreeGLUT 
            //Glut.glutWireSphere(2, 32, 32);
            Gl.glBegin(Gl.GL_QUADS);
            Gl.glVertex2d(o.X, o.Y);
            Gl.glVertex2d(o.X + o.Width, o.Y);
            Gl.glVertex2d(o.X + o.Width, o.Y + o.Height);
            Gl.glVertex2d(o.X, o.Y + o.Height);
            Gl.glEnd();
            Gl.glPopMatrix();
            Gl.glFlush();
            AnT.Invalidate();
        }

        private void AnT_Load(object sender, EventArgs e)
        {

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphTest
{
    public partial class Form1 : Form
    {
        GraphExt ge;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            //въвеждам градовете от фиг.9.1 от учебника
            ge = new GraphExt();
            ge.addVertex("София");//1
            ge.addVertex("Пловдив");//2
            ge.addVertex("Стара Загора");//3
            ge.addVertex("Банско");//4
            ge.addVertex("Сливен");//5
            ge.addVertex("Враца");//6
            ge.addVertex("Видин");//7
            ge.addVertex("Плевен");//8
            ge.addVertex("Велико Търново");//9
            ge.addVertex("Русе");//10
            ge.addVertex("Добрич");//11
            ge.addVertex("Шумен");//12
            ge.addVertex("Варна");//13
            ge.addVertex("Бургас");//14
            ge.addVertex("Кърджали");//15
            ge.addVertex("Хасково");//16
            ge.addVertex("Перник");//17
            ge.addVertex("Благоевград");//18
            
            //Въвеждам ребрата
            makeAdge(1, 2);//София Пловдив
            makeAdge(1, 4);//София Банско
            makeAdge(1, 5);//София Сливен
            makeAdge(1, 6);//София Враца
            makeAdge(1, 8);//София Плевен
            makeAdge(1, 9);//София Велико Търново
            makeAdge(1, 17);//София Перник

            makeAdge(2, 4);//Пловдив Банско
            makeAdge(2, 3);//Пловдив Стара Загора
            makeAdge(2, 15);//Пловдив Кърджали
            makeAdge(2, 16);//Пловдив Хасково

            makeAdge(18, 17);//Благоевград Перник
            makeAdge(18, 4);//Благоевград Банско

            makeAdge(7, 6);//Видин Враца
            makeAdge(7, 8);//Видин Плевен
            
            makeAdge(6, 8);//Враца Плевен

            makeAdge(9, 8);//Велико Търново Плевен
            makeAdge(9, 10);//Велико Търново Русе
            makeAdge(9, 11);//Велико Търново Добрич
            makeAdge(9, 12);//Велико Търново Шумен
            makeAdge(9, 5 );//Велико Търново Сливен
            makeAdge(9, 3 );//Велико Търново Стара Загора

            makeAdge(10, 8 );//Русе Плевен
            makeAdge(10, 11);//Русе Добрич
            makeAdge(10, 12);//Русе Шумен

            makeAdge(11, 13);//Добрич Варна

            makeAdge(12, 13);//Шумен Варна
            makeAdge(12, 5 );//Шумен Сливен

            makeAdge( 5, 3 );//Сливен Стара Загора
            
            makeAdge(14, 13);//Бургас Варна
            makeAdge(14, 5);//Бургас Сливен
            makeAdge(14, 16);//Бургас Хасково

            makeAdge(16, 3);//Хасково Стара Загора


        }
        private void makeAdge(int a, int b)
        {
            ge.AddAdge(a-1, b-1); 
            ge.AddAdge(b-1, a-1);             
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbShowMartix_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = ge.ShowMatrix();
        }

        private void cmbDFS_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = ge.DepthFirstSearch();
        }

        private void cmbBFS_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = ge.BreadthFirstSearch();
        }
         
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


// ثلاث اساسيات في كل فورم 
namespace IE322_1st // نيم سبيس ولازم يكون اسمه نفس اسم البروجكت ولازم يكون موجود في كل الفورمز الثانية في نفس المشروع لانه هو اللي يجمعها
{
    public partial class exam1 : Form  // كلاس وهو اللي يحتوي على كل الاكواد
    {

        //  اذا كتبت شي هنا مباشرة بيكون شي عام لكل الاوامر الثانية زي في الراندوم فورم عرفت قيمه الواي هنا لاني ابغاه يكون معرف في كل الاكواد الثانية

        public exam1() // هذا لانه يحمل نفس اسم الكلاس فيسمى constructor  ونحط فيهالاشياء اللي نبغاها تشتغل اول ما تفتح الفورم زي في الكومبو فورم
        {
            InitializeComponent();
        }
    }
}

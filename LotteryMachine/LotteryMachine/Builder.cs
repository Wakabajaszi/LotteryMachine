using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotteryMachine
{
    public class Product
    {
        string name;
        string surname;
        int sex;

        public string Name { get { return name; } set { name = value; } }
        public string Surname { get { return surname; } set { surname = value; } }
        public int Sex { get { return sex; } set { sex = value; } }
    }

    public abstract class Builder
    {
        protected Product product;
        public Product Product { get { return product; } }
        public void AddForm() { product = new Product(); }


        public abstract string selectName();
        public abstract string selectSurname();
        public abstract int selectSex();
        public abstract void AddOrEdit(string name, string surname, int sex);
    }
    class EditMemberForm : Builder //Concrete Builder
    {
        int id;
        public EditMemberForm(int id)
        {
            this.id = id;
        }

        public override string selectName()
        {
            return "";
        }

        public override string selectSurname()
        {
            return "";
        }

        public override int selectSex()
        {
            return 0;
        }

        public override void AddOrEdit(string name, string surname, int sex)
        {


        }
    }
    class AddMemberForm1 : Builder //Concrete Builder
    {
        int id;
        public AddMemberForm1(int id)
        {
            this.id = id;
        }

        public override string selectName()
        {
            return "";
        }

        public override string selectSurname()
        {
            return "";
        }

        public override int selectSex()
        {
            return 0;
        }

        public override void AddOrEdit(string name, string surname, int sex)
        {


        }
    }
    public class CreateFormDirector
    {
        private Builder builder;
        public Builder Builder
        {
            get { return builder; }
            set { builder = value; }
        }

        public Product Choose()
        {
            builder.selectName();
            builder.selectSurname();
            builder.selectSex();
            return builder.Product;
        }
    }
}
            

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
        string city;
        string adress;
        string postCode;


        public string Name { get { return name; } set { name = value; } }
        public string Surname { get { return surname; } set { surname = value; } }
        public int Sex { get { return sex; } set { sex = value; } }
        public string City { get { return city; } set { city = value; } }
        public string Adress { get { return adress; } set { adress = value; } }
        public string PostCode { get { return postCode; } set { postCode = value; } }
    }

    public abstract class Builder
    {
        protected Product product;
        public Product Product { get { return product; } }
        public void AddForm() { product = new Product(); }


        public abstract string selectName();
        public abstract string selectSurname();
        public abstract int selectSex();
        public abstract string selectCity();
        public abstract string selectAdress();
        public abstract string selectPostCode();
        public abstract void AddOrEdit(string name, string surname, int sex, string city, string adress, string postalCode);
    }
    class EditMemberFormConcreteBuilder : Builder 
    {
        int id;
        MemberService.MemberServiceClient serviceClient = new MemberService.MemberServiceClient();
        MemberService.MemberData member;

        public EditMemberFormConcreteBuilder(int id)
        {
            this.id = id;
            member = serviceClient.GetMemberById(id);
           
        }
        
        
        public override string selectName()
        {
            return member.Name;
        }

        public override string selectSurname()
        {
            
            return member.Surname;
        }

        public override int selectSex()
        {

            return member.SexId;
        }

       public override string selectCity()
        {
            return member.City;
        }

        public override string selectAdress()
        {
            return member.Street;
        }

        public override string selectPostCode()
        {
            return member.PostalCode;
        }
        public override void AddOrEdit(string name, string surname, int sex, string city, string adress, string postalCode)
        {

            MemberService.MemberData editedMember = new MemberService.MemberData()
            {
                Id = id,
                Name = name,
                Surname = surname,
                SexId = sex,
                City = city,
                Street = adress,
                PostalCode = postalCode
            };
            serviceClient.EditMember(editedMember);
            
        }
    }
    class AddMemberFormConcreteBuilder : Builder 
    {
        
        public AddMemberFormConcreteBuilder()
        {
           
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

        public override string selectCity()
        {
            return "";
        }

        public override string selectAdress()
        {
            return "";
        }

        public override string selectPostCode()
        {
            return "";
        }
        public override void AddOrEdit(string name, string surname, int sex, string city, string adress, string postalCode)
        {
            MemberService.MemberServiceClient serviceClient = new MemberService.MemberServiceClient();
            MemberService.MemberData member = new MemberService.MemberData() 
            {
                Name = name,
                Surname = surname,
                SexId = sex,
                City = city,
                Street = adress,
                PostalCode = postalCode
            };


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
            builder.selectCity();
            builder.selectAdress();
            builder.selectPostCode();
            return builder.Product;
        }
    }
}
            

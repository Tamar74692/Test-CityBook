using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BL
{
    public class Conversions
    {
        //child
        public Child GetChildFromDTO(ChildDTO child)
        {
            Child rChild = new Child();
            rChild.Identity = child.Identity;
            rChild.Name = child.Name;
            rChild.DateOfBirth = child.DateOfBirth;
            rChild.ID = child.ID;
            return rChild;
        }
        public ChildDTO GetChildToDTO(Child child)
        {
            ChildDTO rChild = new ChildDTO();
            rChild.Identity = child.Identity;
            rChild.Name = child.Name;
            rChild.DateOfBirth = child.DateOfBirth;
            rChild.ID = child.ID;
            return rChild;
        }

        //person
        public Person GetPersonFromDTO(PersonDTO person)
        {
            Person rPerson = new Person();
            rPerson.Identity = person.Identity;
            rPerson.FirstName = person.FirstName;
            rPerson.LastName = person.LastName;
            rPerson.ID = person.ID;
            rPerson.DateOfBirth = person.DateOfBirth;
            rPerson.MaleOrFemale = person.MaleOrFemale;
            rPerson.HMO = person.HMO;
            return rPerson;
        }
        public PersonDTO GetPersonToDTO(Person person)
        {
            PersonDTO rPerson = new PersonDTO();
            rPerson.Identity = person.Identity;
            rPerson.FirstName = person.FirstName;
            rPerson.LastName = person.LastName;
            rPerson.ID = person.ID;
            rPerson.DateOfBirth = person.DateOfBirth;
            rPerson.MaleOrFemale = person.MaleOrFemale;
            rPerson.HMO = person.HMO;
            return rPerson;
        }

    }
}

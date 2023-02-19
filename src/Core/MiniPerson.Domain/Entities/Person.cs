using MiniPerson.Domain.Common;

namespace MiniPerson.Domain.Entities
{
    public class Person : BaseAuditableEntity
    {
        #region Props
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string NationCode { get; private set; }
        #endregion

        #region Ctor
        private Person() { }

        public Person(string firstName,
                      string lastName,
                      string nationCode)
        {
            FirstName = firstName;
            LastName = lastName;
            NationCode = nationCode;
        }

        public Person(long id,
                      string firstName,
                      string lastName,
                      string nationCode)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            NationCode = nationCode;
        }
        #endregion

        #region Commands
        public static Person Create(string firstName,
                                    string lastName,
                                    string nationCoden)
            => new(firstName, lastName, nationCoden);

        public void Update(Person person)
        {
            FirstName = person.FirstName;
            LastName = person.LastName;
            NationCode = person.NationCode;
        }

        public static Person UpdateNew(long id,
                                    string firstName,
                                    string lastName,
                                    string nationCode)
        {
            return new Person(id, firstName, lastName, nationCode);
        }
        #endregion
    }
}
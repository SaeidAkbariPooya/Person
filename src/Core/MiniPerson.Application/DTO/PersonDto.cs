using MiniPerson.Application.DTO;
using MiniPerson.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace MiniPerson.Domain.DTO
{
    public class PersonDto : BaseAuditableEntityDto
    {
        #region Props
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationCode { get; set; }
        #endregion
    }
}
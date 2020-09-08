namespace SpecificationApp
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// This class contains IsSatisfiedBy() method from specification class to check if the email is valid.
    /// </summary>
    internal class ValidEmailSpecification : Specification<OrderRequest>
    {
        /// <summary>
        /// Checks if the sender's email format is valid.
        /// </summary>
        /// <param name="data">The OrderRequest object.</param>
        /// <param name="errors">List used to communicate outwards if something happens inside the specification/validation.</param>
        /// <returns>The boolean value if the address of the mailAdress object is the same as the sender's email.</returns>
        public override bool IsSatisfiedBy(OrderRequest data, ref ICollection<string> errors)
        {
            try
            {
                System.Net.Mail.MailAddress mailAddress = new System.Net.Mail.MailAddress(data.SenderEmail);
                return mailAddress.Address == data.SenderEmail;
            }
            catch
            {
                return false;
            }
        }
    }
}

namespace SpecificationApp
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ValidContactNumber : Specification<OrderRequest>
    {
        private int phoneNumberLength = 11;

        public override bool IsSatisfiedBy(OrderRequest data, ref ICollection<string> errors)
        {
            if (string.IsNullOrEmpty(data.SenderContactNumber))
            {
                return false;
            }

            if (data.SenderContactNumber.Length > this.phoneNumberLength)
            {
                return false;
            }

            if (!data.SenderContactNumber[0].Equals('0') || !data.SenderContactNumber[1].Equals('9'))
            {
                return false;
            }

            return true;
        }
    }
}

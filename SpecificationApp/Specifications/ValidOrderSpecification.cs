namespace SpecificationApp
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ValidOrderSpecification : Specification<OrderRequest>
    {
        public override bool IsSatisfiedBy(OrderRequest data, ref ICollection<string> errors)
        {
            var logicalSpecification = new ValidContactNumber().And(new ValidEmailSpecification()).And(new ValidNameSpecification());
            return logicalSpecification.IsSatisfiedBy(data, ref errors);
        }
    }
}

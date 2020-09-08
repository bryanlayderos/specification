// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace SpecificationApp
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Class that controls the input and validation of OrderRequest properties.
    /// </summary>
    public class Program
    {
        private readonly OrderRequest orderRequest;

        private ICollection<string> errors = new List<string>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Program"/> class.
        /// </summary>
        public Program()
        {
            this.orderRequest = new OrderRequest();
        }

        public static void Main(string[] args)
        {
            Program program = new Program();

            program.SetValues();
            program.Validate();

            Console.ReadLine();
        }

        /// <summary>
        /// Sets the OrderRequest object properties from the console input.
        /// </summary>
        public void SetValues()
        {
            Console.Write("Enter sender email: ");
            this.orderRequest.SenderEmail = Console.ReadLine().Trim();

            Console.Write("Enter sender name: ");
            this.orderRequest.SenderName = Console.ReadLine().Trim();

            Console.Write("Enter sender contact number: ");
            this.orderRequest.SenderContactNumber = Console.ReadLine().Trim();
        }

        /// <summary>
        /// Validates the OrderRequest object properties to the specification objects.
        /// </summary>
        public void Validate()
        {
            bool result = new ValidOrderSpecification().IsSatisfiedBy(this.orderRequest, ref this.errors);

            if (result)
            {
                Console.WriteLine("Order Request is valid");
            }
            else
            {
                Console.WriteLine("Order Request is not valid");
            }
        }
    }
}

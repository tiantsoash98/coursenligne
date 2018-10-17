using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTEK.Architecture.Infrastructure.Validator.Abstract
{
    public abstract class ValidatorBusinessBase
    {
        private readonly List<IRule> Rules;
        public abstract void AddRules();

        protected ValidatorBusinessBase()
        {
            Rules = new List<IRule>();
        }

        public void AddRule(IRule rule)
        {
            Rules.Add(rule);
        }

        public void AddRule(string propertyName, IRule rule)
        {
            Rules.Add(rule);
        }

        private void DefineRules()
        {
            Rules.Clear();
            AddRules();
        }

        public ValidationResult Validate()
        {
            DefineRules();

            var validationsFailures = new List<ValidationFailure>();
            ValidationFailure _result = null;

            foreach(var rule in Rules)
            {
                _result = rule.Validate();

                if(_result != null)
                {
                    validationsFailures.Add(_result);
                }
            }

            return new ValidationResult(validationsFailures);
        }
    }
}

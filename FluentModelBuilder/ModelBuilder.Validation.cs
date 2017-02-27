﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DevExpress.Persistent.Validation;

namespace ExpressApp.FluentModelBuilder.XAF
{
    public partial class ModelBuilder<T>
    {
        #region HasRuleObjectExists
        public ModelBuilder<T> HasRuleObjectExists(string criteria)
        {
            return WithAttribute(new RuleObjectExistsAttribute(criteria));
        }

        public ModelBuilder<T> HasRuleObjectExists(DefaultContexts targetContext, string criteria)
        {
            return WithAttribute(new RuleObjectExistsAttribute(targetContext, criteria));
        }

        public ModelBuilder<T> HasRuleObjectExists(string id, DefaultContexts targetContext, string criteria)
        {
            return WithAttribute(new RuleObjectExistsAttribute(id, targetContext, criteria));
        }

        public ModelBuilder<T> HasRuleObjectExists(string id, string targetContextIDs, string criteria)
        {
            return WithAttribute(new RuleObjectExistsAttribute(id, targetContextIDs, criteria));
        }

        public ModelBuilder<T> HasRuleObjectExists(string id, DefaultContexts targetContext, string criteria, string messageTemplate)
        {
            return WithAttribute(new RuleObjectExistsAttribute(id, targetContext, criteria, messageTemplate));
        }

        public ModelBuilder<T> HasRuleObjectExists(string id, string targetContextIDs, string criteria, string messageTemplate)
        {
            return WithAttribute(new RuleObjectExistsAttribute(id, targetContextIDs, criteria, messageTemplate));
        }
        #endregion

        

        

        

        
    }
}
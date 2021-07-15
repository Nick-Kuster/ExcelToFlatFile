using ExcelToFlatFileFramework.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelToFlatFileFramework.Attributes
{
    [System.AttributeUsage(System.AttributeTargets.Property |
                       System.AttributeTargets.Field, AllowMultiple =true)
]
    public class AmosRules : System.Attribute
    {
        public AmosRuleType AmosRuleType;
        public string RuleValueString;
        public int RuleValueInt;

        public AmosRules(AmosRuleType amosRuleType)
        {
            this.AmosRuleType = amosRuleType;
        }
        public AmosRules(AmosRuleType amosRuleType, string amosRuleValueString)
        {
            this.AmosRuleType = amosRuleType;
            this.RuleValueString = amosRuleValueString;
        }
        public AmosRules(AmosRuleType amosRuleType, int amosRuleValueInt)
        {
            this.AmosRuleType = amosRuleType;
            this.RuleValueInt = amosRuleValueInt;
        }
    }
}

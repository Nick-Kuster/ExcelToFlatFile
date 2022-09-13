using ExcelToFlatFileFramework.Domain.Attributes;
using Npoi.Mapper.Attributes;

namespace ExcelToFlatFileFramework.Domain.InTemplates
{
    public class WPImportInput : ValidationBase
    {
        [AmosOutputLength(120)]
        [AmosRequired]
        [Column("WORKORDER NUMBER")]
        public string WorkOrderNumber { get; set; }
        [AmosOutputLength(12)]
        [AmosRequired]
        [Column("ATA CODE")]
        public string AtaCode { get; set; }
        [AmosOutputLength(10)]
        [AmosRequired]
        [Column("DUE DATE")]
        public string DueDate { get; set; }
        [AmosOutputLength(70)]
        [AmosRequired]
        [Column("HEADLINE")]
        public string Headline { get; set; }
        [AmosOutputLength(5000)]
        [AmosRequired]
        [Column("PROBLEM DESCRIPTION")]
        public string ProblemDescription { get; set; }
        [Column("FILE URL")]
        public string FileUrl { get; set; }

        [Column("DURATION")]
        public int Duration { get; set; }
        [Column("QUANTITY")]
        public int Quantity { get; set; }
        protected bool Equals(WPImportInput other)
        {
            return WorkOrderNumber == other.WorkOrderNumber && AtaCode == other.AtaCode && DueDate == other.DueDate && Headline == other.Headline && ProblemDescription == other.ProblemDescription && Duration == other.Duration && Quantity == other.Quantity;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((WPImportInput)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = (WorkOrderNumber != null ? WorkOrderNumber.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (AtaCode != null ? AtaCode.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (DueDate != null ? DueDate.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Headline != null ? Headline.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (ProblemDescription != null ? ProblemDescription.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (FileUrl != null ? FileUrl.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ Duration;
                hashCode = (hashCode * 397) ^ Quantity;
                return hashCode;
            }
        }

        public static bool operator ==(WPImportInput left, WPImportInput right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(WPImportInput left, WPImportInput right)
        {
            return !Equals(left, right);
        }

    }
}

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
        [AmosOutputLength(32)]
        [Column("PART 1")]
        public string Part1 { get; set; }
        [AmosOutputLength(36)]
        [Column("PART DESCRIPTION 1")]
        public string PartDescription1 { get; set; }
        [AmosOutputLength(32)]
        [Column("REQUIRED QTY 1")]
        public string RequiredQuantity1 { get; set; }
        [AmosOutputLength(32)]
        [Column("PART 2")]
        public string Part2 { get; set; }
        [AmosOutputLength(36)]
        [Column("PART DESCRIPTION 2")]
        public string PartDescription2 { get; set; }
        [AmosOutputLength(32)]
        [Column("REQUIRED QTY 2")]
        public string RequiredQuantity2 { get; set; }
        [AmosOutputLength(32)]
        [Column("PART 3")]
        public string Part3 { get; set; }
        [AmosOutputLength(36)]
        [Column("PART DESCRIPTION 3")]
        public string PartDescription3 { get; set; }
        [AmosOutputLength(32)]
        [Column("REQUIRED QTY 3")]
        public string RequiredQuantity3 { get; set; }
        [AmosOutputLength(32)]
        [Column("PART 4")]
        public string Part4 { get; set; }
        [AmosOutputLength(36)]
        [Column("PART DESCRIPTION 4")]
        public string PartDescription4 { get; set; }
        [AmosOutputLength(32)]
        [Column("REQUIRED QTY 4")]
        public string RequiredQuantity4 { get; set; }
        [AmosOutputLength(32)]
        [Column("PART 5")]
        public string Part5 { get; set; }
        [AmosOutputLength(36)]
        [Column("PART DESCRIPTION 5")]
        public string PartDescription5 { get; set; }
        [AmosOutputLength(32)]
        [Column("REQUIRED QTY 5")]
        public string RequiredQuantity5 { get; set; }
        [AmosOutputLength(32)]
        [Column("PART 6")]
        public string Part6 { get; set; }
        [AmosOutputLength(36)]
        [Column("PART DESCRIPTION 6")]
        public string PartDescription6 { get; set; }
        [AmosOutputLength(32)]
        [Column("REQUIRED QTY 6")]
        public string RequiredQuantity6 { get; set; }
        [AmosOutputLength(32)]
        [Column("PART 7")]
        public string Part7 { get; set; }
        [AmosOutputLength(36)]
        [Column("PART DESCRIPTION 7")]
        public string PartDescription7 { get; set; }
        [AmosOutputLength(32)]
        [Column("REQUIRED QTY 7")]
        public string RequiredQuantity7 { get; set; }
        [AmosOutputLength(32)]
        [Column("PART 8")]
        public string Part8 { get; }
        [AmosOutputLength(36)]
        [Column("PART DESCRIPTION 8")]
        public string PartDescription8 { get; set; }
        [AmosOutputLength(32)]
        [Column("REQUIRED QTY 8")]
        public string RequiredQuantity8 { get; set; }
        [AmosOutputLength(32)]
        [Column("PART 9")]
        public string Part9 { get; set; }
        [AmosOutputLength(36)]
        [Column("PART DESCRIPTION 9")]
        public string PartDescription9 { get; set; }
        [AmosOutputLength(32)]
        [Column("REQUIRED QTY 9")]
        public string RequiredQuantity9 { get; set; }
        [AmosOutputLength(32)]
        [Column("PART 10")]
        public string Part10 { get; set; }
        [AmosOutputLength(36)]
        [Column("PART DESCRIPTION 10")]
        public string PartDescription10 { get; set; }
        [AmosOutputLength(32)]
        [Column("REQUIRED QTY 10")]
        public string RequiredQuantity10 { get; set; }

        [Column("DURATION")]
        public int Duration { get; set; }
        [Column("QUANTITY")]
        public int Quantity { get; set; }
        protected bool Equals(WPImportInput other)
        {
            return WorkOrderNumber == other.WorkOrderNumber && AtaCode == other.AtaCode && DueDate == other.DueDate && Headline == other.Headline && ProblemDescription == other.ProblemDescription && Part1 == other.Part1 && PartDescription1 == other.PartDescription1 && RequiredQuantity1 == other.RequiredQuantity1 && Part2 == other.Part2 && PartDescription2 == other.PartDescription2 && RequiredQuantity2 == other.RequiredQuantity2 && Part3 == other.Part3 && PartDescription3 == other.PartDescription3 && RequiredQuantity3 == other.RequiredQuantity3 && Part4 == other.Part4 && PartDescription4 == other.PartDescription4 && RequiredQuantity4 == other.RequiredQuantity4 && Part5 == other.Part5 && PartDescription5 == other.PartDescription5 && RequiredQuantity5 == other.RequiredQuantity5 && Part6 == other.Part6 && PartDescription6 == other.PartDescription6 && RequiredQuantity6 == other.RequiredQuantity6 && Part7 == other.Part7 && PartDescription7 == other.PartDescription7 && RequiredQuantity7 == other.RequiredQuantity7 && Part8 == other.Part8 && PartDescription8 == other.PartDescription8 && RequiredQuantity8 == other.RequiredQuantity8 && Part9 == other.Part9 && PartDescription9 == other.PartDescription9 && RequiredQuantity9 == other.RequiredQuantity9 && Part10 == other.Part10 && PartDescription10 == other.PartDescription10
                   && RequiredQuantity10 == other.RequiredQuantity10 && Duration == other.Duration && Quantity == other.Quantity;
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
                hashCode = (hashCode * 397) ^ (Part1 != null ? Part1.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (PartDescription1 != null ? PartDescription1.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (RequiredQuantity1 != null ? RequiredQuantity1.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Part2 != null ? Part2.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (PartDescription2 != null ? PartDescription2.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (RequiredQuantity2 != null ? RequiredQuantity2.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Part3 != null ? Part3.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (PartDescription3 != null ? PartDescription3.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (RequiredQuantity3 != null ? RequiredQuantity3.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Part4 != null ? Part4.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (PartDescription4 != null ? PartDescription4.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (RequiredQuantity4 != null ? RequiredQuantity4.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Part5 != null ? Part5.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (PartDescription5 != null ? PartDescription5.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (RequiredQuantity5 != null ? RequiredQuantity5.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Part6 != null ? Part6.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (PartDescription6 != null ? PartDescription6.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (RequiredQuantity6 != null ? RequiredQuantity6.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Part7 != null ? Part7.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (PartDescription7 != null ? PartDescription7.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (RequiredQuantity7 != null ? RequiredQuantity7.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Part8 != null ? Part8.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (PartDescription8 != null ? PartDescription8.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (RequiredQuantity8 != null ? RequiredQuantity8.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Part9 != null ? Part9.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (PartDescription9 != null ? PartDescription9.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (RequiredQuantity9 != null ? RequiredQuantity9.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Part10 != null ? Part10.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (PartDescription10 != null ? PartDescription10.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (RequiredQuantity10 != null ? RequiredQuantity10.GetHashCode() : 0);
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

using BOSCommon.Constants;
using BOSLib;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BOSERP
{
    [Table("STTransactionLoggers")]
    public class TransactionLogger
    {
        [Key]
        [Column("STTransactionLoggerID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public Guid Id { get; set; }

        [StringLength(10)]
        public string AAStatus { get; set; } = ObjectStatus.Alive;

        public DateTime? AACreatedDate { get; set; }

        [StringLength(50)]
        public string AACreatedUser { get; set; }

        [StringLength(255)]
        public string STModuleName { get; set; }

        [StringLength(50)]
        public string STTransactionActionName { get; set; }

        public int? STTransactionObjectID { get; set; }

        public string STTransactionObjectRefID { get; set; }

        [StringLength(50)]
        public string STTransactionType { get; set; }

        public string STTransactionErrorMessage { get; set; }

        public bool? STTransactionFixed { get; set; } = false;

    }
}
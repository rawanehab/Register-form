using System;
using System.ComponentModel.DataAnnotations;

public class RegTable
{
    [Key]
    public int REG_ID { get; set; }
    public string FIRST_NAME { get; set; }
    public string LAST_NAME { get; set; }

    public Byte[] REG_PHOTO { get; set; }
    public string EMAIL { get; set; }
    public string pass { get; set; }
    public string phone { get; set; }
    public string gender { get; set; }

    public Byte[] file_reg { get; set; }

}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyECommerce.Entity.Enum
{
    public enum EnumOrderState
    {
        [Display(Name = " On Waiting Status")]
        WaitingOrder=1,
        [Display(Name = " Order was refused")]
        RefusedOrder=2,
        [Display(Name = " Order was completed")]
        CompletedOrder=3,
        [Display(Name = " Order was cancelled")]
        CancelledOrder=4
    }
}

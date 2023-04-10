using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FXFellowDashboard
{
    public enum Headers
    {
        Account = 0,
        Currency = 1,
        Lot = 2,
        Active = 3,
        Spread = 4,
        Swap = 5,
        PnL = 6,
        CloseAt = 7,
        Commission = 8
    }

    public enum TradingDeskState
    {
        ShowOrder = 0,
        ShowPending = 1,
        ShowAlert = 2
    }

    public enum ShowOrderState
    {
        ShowAll = 0,
        ShowPart = 1
    }

    public enum ManageAlertState
    {
        AddAlert = 0,
        RemoveAlert = 1
    }

    public enum MarketPending
    {
        MarketOrder = 0,
        PendingOrder = 1
    }

    public enum ControlPendingState
    {
        AddPending = 0,
        ModifyPending = 1,
        DeletePending = 2
    }
}

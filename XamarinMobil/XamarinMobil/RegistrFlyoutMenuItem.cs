using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinMobil
{
    public class RegistrFlyoutMenuItem
    {
        public RegistrFlyoutMenuItem()
        {
            TargetType = typeof(RegistrFlyoutMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}
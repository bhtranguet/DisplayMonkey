/*!
* DisplayMonkey source file
* http://displaymonkey.org
*
* Copyright (c) 2019 Fuel9 LLC and contributors
*
* Released under the MIT license:
* http://opensource.org/licenses/MIT
*/

//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DisplayMonkey.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Weather : Frame
    {
        public WeatherTypes Type { get; set; }
        public Nullable<WeatherProviders> Provider { get; set; }
        public Nullable<int> AccountId { get; set; }
    
        public virtual OauthAccount OauthAccount { get; set; }
    }
}
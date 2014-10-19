﻿using mdPhone.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdPhone.ViewModel
{
   public  class CalendarViewModel
    {
        //获取token
        public static void GetTodo(string token, HttpWeb.callbackResult callback)
        {
            string uriStr = MDApi.calendar_todo + token + "&format=json";
            HttpWeb.CreateGetHttpResponse(uriStr, null, callback);
        }

        //获取token
        public static void CalendarDetail(string token,string cId, HttpWeb.callbackResult callback)
        {
            string uriStr = MDApi.calendar_detail + token + "&c_id=" + cId + "&format=json";
            HttpWeb.CreateGetHttpResponse(uriStr, null, callback);
        } 


    }
}

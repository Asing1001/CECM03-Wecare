<%@ WebHandler Language="C#" Class="HandlerSendCoupon" %>

using System;
using System.Web;



public class HandlerSendCoupon : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {
        var email = context.Request.Cookies["Email"].Value;
        var name = HttpUtility.UrlDecode(context.Request.Cookies["login"].Value);
        var coupon = "FD1FBN2FMNJT"; //clsUser.CreateSalt();
        //寫回DB
        
        //寄信
        clsUser.SendCouponMail(email, name, coupon);
        
        
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}
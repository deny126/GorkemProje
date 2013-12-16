<%@ Page Title="" Language="C#" MasterPageFile="~/Muhasebe.Master" AutoEventWireup="true" CodeBehind="iletisim.aspx.cs" Inherits="MuhasebeWEB.iletisim" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="row p1">
            <div class="grid_5">
                <div class="bg-6 block-6">
                    <h2>İletişim</h2>
                    <iframe id="map_canvas" src="http://maps.google.com/maps?f=q&amp;source=s_q&amp;hl=en&amp;geocode=&amp;q=Brooklyn,+New+York,+NY,+United+States&amp;aq=0&amp;sll=37.0625,-95.677068&amp;sspn=61.282355,146.513672&amp;ie=UTF8&amp;hq=&amp;hnear=Brooklyn,+Kings,+New+York&amp;ll=40.649974,-73.950005&amp;spn=0.01628,0.025663&amp;z=14&amp;iwloc=A&amp;output=embed"></iframe>
                    <dl class="address">
                        <dt>İran Cad No:21/467, <br>
                        Çankaya Ankara.</dt>
                        
                        <dd><span>Tel:</span>05555555555</dd>
                        <dd><span>FAX:</span>03125555555</dd>
                        <dd><span class="e-mail">E-mail: <a href="#" class="demo">cevdetakyol@mevzuat.org</a></span></dd>
                    </dl>
                </div>
            </div>
            <div class="grid_7">
                <div class="bg-6 block-7">
                    <h2 class="regular">MEsaj GÖNDERİN</h2>
                    <form id="contact-form">
                        <div class="success">Mesajınız iletildi!<br>
                            <strong>En kısa zamanda sizinle iletişime geçeceğiz.</strong>
                        </div>
                        <fieldset>
                            <label class="name">
                                <input type="text" value="Ad Soyad:">
                                <span class="error">*Geçerli bir Ad giriniz.</span>
                                <span class="empty">*Zorunlu Alan.</span>
                            </label>
                            <label class="email">
                                <input type="email" value="Email:">
                                <span class="error">*Geçerli bir email giriniz.</span>
                                <span class="empty">*Zorunlu Alan.</span>
                            </label>
                            <label class="phone">
                                <input type="tel" value="Telefon:">
                                <span class="error">*Geçerli bir numara giriniz.</span> 
                                <span class="empty">*Zorunlu Alan.</span>
                            </label>
                            <label class="message">
                                <textarea>Mesaj:</textarea>
                                <span class="error">*Mesajınız çok kısa.</span>
                                <span class="empty">*Zorunlu Alan.</span>
                            </label>
                            <div class="form_buttons">
                                <a class="btn" href="#" data-type="submit">GÖNDER</a>
                            </div>
                        </fieldset>
                    </form>
                </div>
            </div>
        </div>
</asp:Content>

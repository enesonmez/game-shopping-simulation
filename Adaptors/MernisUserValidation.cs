using System;
using RestSharp;
using GameShopppingSimulation.Abstract;
using GameShopppingSimulation.Entity;
using System.Xml.Linq;

namespace GameShopppingSimulation.Concrete
{
    public class MernisUserValidation : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            try 
            {
                var data = @"<?xml version=""1.0"" encoding=""utf-8""?>
                            <soap:Envelope xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:soap=""http://schemas.xmlsoap.org/soap/envelope/"">
                            <soap:Body>
                                <TCKimlikNoDogrula xmlns=""http://tckimlik.nvi.gov.tr/WS"">
                                <TCKimlikNo>"+gamer.IdentityNo+@"</TCKimlikNo>
                                <Ad>"+gamer.FirstName!.ToUpper()+@"</Ad>
                                <Soyad>"+gamer.LastName!.ToUpper()+@"</Soyad>
                                <DogumYili>"+gamer.BirthDay.Year+@"</DogumYili>
                                </TCKimlikNoDogrula>
                            </soap:Body>
                            </soap:Envelope>";

                var client = new RestClient("https://tckimlik.nvi.gov.tr/Service/KPSPublic.asmx");
                var request = new RestRequest("https://tckimlik.nvi.gov.tr/Service/KPSPublic.asmx",Method.Post);
                request.AddHeader("Host", "tckimlik.nvi.gov.tr");
                request.AddHeader("Content-Type", "text/xml; charset=utf-8");
                request.AddHeader("SOAPAction", "\"http://tckimlik.nvi.gov.tr/WS/TCKimlikNoDogrula\"");
                request.AddParameter("text/xml", data, ParameterType.RequestBody);
                RestResponse response = client.Execute(request);

                var doc = XDocument.Parse(response.Content!);  
                XNamespace ns = "http://tckimlik.nvi.gov.tr/WS";  
                var result = doc.Root!.Descendants(ns + "TCKimlikNoDogrulaResponse").Elements(ns + "TCKimlikNoDogrulaResult").FirstOrDefault();
                if (!String.IsNullOrEmpty(result!.Value.ToString()))  
                {  
                    return Convert.ToBoolean(result.Value);  
                } 
                return false;
            }
            catch
            {
                return false;
            }
        }
    }
}
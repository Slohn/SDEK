﻿using System.ComponentModel.DataAnnotations;
using System.Net.Http.Headers;
using System.Reflection;
using SDEK;
using SDEK.Models;

public class Test
{
    public static void Main(string[] args)
    {
        //var res = Integration.Auth(new SDEK.Models.AuthDTO
        //{
        //    grant_type = "client_credentials",
        //    client_id = "EMscd6r9JnFiQ3bLoyjJY6eM78JrJceI",
        //    client_secret = "PjLZkKBHEiLK3YsjtNrt3TGNG0ahs3kG"
        //});
        //Integration.RegOrder(new OrderDTO
        //{
        //    Tariff_code = 119,
        //    Shipment_point = "MSK67",
        //    Sender = new Sender
        //    {
        //        company = "Компания",
        //        name = "Петров Петр",
        //        email = "msk@cdek.ru",
        //        phones = new List<Phone>
        //        {
        //            new Phone {number = "+79134000101" }
        //        }
        //    },
        //    Recipient = new Recipient
        //    {
        //        name = "Иванов Иван",
        //        company = "Иванов Иван",
        //        phones = new List<Phone>
        //        {
        //            new Phone {number = "+79134000404" }
        //        }
        //    },
        //    ToLocation = new ToLocation
        //    {
        //        address = "ул. Блюхера, 32",

        //    },
        //    Services = new List<Service> {
        //        new Service { code = "INSURANCE" }
        //    },
        //    Packages = new List<Package>
        //    {
        //        new Package
        //        {
        //            number = "bar-001",
        //            weight = 1000,
        //            length = 10,
        //            width = 140,
        //            height = 140,
        //            items= new List<Item>
        //            {
        //                new Item
        //                {
        //                    ware_key = "00055",
        //                    payment =  new Payment{value = 3000 },
        //                    name = "Товар",
        //                    cost = 300,
        //                    amount = 2,
        //                    weight = 700
        //                },


        //            }
        //        }
        //    }
        //}
        //);

        //Integration.GetOrderInfoByUuid("72753031-9bf3-41dc-ace7-a33e50dc28f5");
        //Integration.GetAllOffices("eyJhbGciOiJSUzI1NiIsInR5cCI6IkpXVCJ9.eyJzY29wZSI6WyJvcmRlcjphbGwiLCJwYXltZW50OmFsbCJdLCJleHAiOjE2NzM0NDM5NDUsImF1dGhvcml0aWVzIjpbInNoYXJkLWlkOnJ1LTAxIiwiY2xpZW50LWNpdHk60J3QvtCy0L7RgdC40LHQuNGA0YHQuiwg0J3QvtCy0L7RgdC40LHQuNGA0YHQutCw0Y8g0L7QsdC70LDRgdGC0YwiLCJmdWxsLW5hbWU60KLQtdGB0YLQuNGA0L7QstCw0L3QuNC1INCY0L3RgtC10LPRgNCw0YbQuNC4INCY0JwsINCe0JHQqdCV0KHQotCS0J4g0KEg0J7Qk9Cg0JDQndCY0KfQldCd0J3QntCZINCe0KLQktCV0KLQodCi0JLQldCd0J3QntCh0KLQrNCuIiwiYWNjb3VudC1sYW5nOnJ1cyIsImNvbnRyYWN0OtCY0Jwt0KDQpC3Qk9Cb0JMtMjIiLCJhcGktdmVyc2lvbjoxLjEiLCJhY2NvdW50LXV1aWQ6ZTkyNWJkMGYtMDVhNi00YzU2LWI3MzctNGI5OWMxNGY2NjlhIiwiY2xpZW50LWlkLWVjNTplZDc1ZWNmNC0zMGVkLTQxNTMtYWZlOS1lYjgwYmI1MTJmMjIiLCJjbGllbnQtaWQtZWM0OjE0MzQ4MjMxIiwic29saWQtYWRkcmVzczpmYWxzZSIsImNvbnRyYWdlbnQtdXVpZDplZDc1ZWNmNC0zMGVkLTQxNTMtYWZlOS1lYjgwYmI1MTJmMjIiXSwianRpIjoiZDkyNzZhMjMtYTdhZi00NTY2LWFiYzYtZjk1MzFmMWZjNGZhIiwiY2xpZW50X2lkIjoiRU1zY2Q2cjlKbkZpUTNiTG95akpZNmVNNzhKckpjZUkifQ.Oi8gyq1-Pk6AwrRMTPCIMiF6itYjLZZWGGyDqQhXDX7SgF6Px9r4qznVklyPqH2SVjLS1A8dRbhXTCZAhoMdEq7Wz5u3FBACXv5WSP0-lix8c0UcXEvj-42ltZjihBh_WMvRDnqnH5ZYKVCjp6LDA1qgGic7mNAm4vowrYH_d4RhfP7dQw2b7e_SBUZdd08mBB_f_5VPGtq-1EmlLg6pcl25EbfnqebtgFvmCHHQhOopd1L9m27T_ahZ91QcMwFgopX0-Qm2ljm_gH-JG1szxGQ1pOQlUg_C4VBOSjff3IsosMbAH_CamvH7jNXyzLKgVkLtcWkKtmdhWvPN17gkFw");
        //Integration.OrderUpdate(new OrderDTO
        //{
        //    uuid = "72753031-f57e-4b66-b69d-080828fd105b",
        //    Tariff_code = 119,
        //    Shipment_point = "MSdfdfsdfsdf",
        //    Sender = new Sender
        //    {
        //        company = "Компания",
        //        name = "Петров Петр",
        //        email = "msk@cdek.ru",
        //        phones = new List<Phone>
        //          {
        //              new Phone {number = "+79134000101" }
        //          }
        //    },
        //    Recipient = new Recipient
        //    {
        //        name = "Иванов Иван",
        //        company = "Иванов Иван",
        //        phones = new List<Phone>
        //          {
        //              new Phone {number = "+79134000404" }
        //          }
        //    },
        //    ToLocation = new ToLocation
        //    {
        //        address = "ул. Блюхера, 32",

        //    },
        //    Services = new List<Service> {
        //          new Service { code = "INSURANCE" }
        //      },
        //    Packages = new List<Package>
        //      {
        //          new Package
        //          {
        //              number = "bar-001",
        //              weight = 1000,
        //              length = 10,
        //              width = 140,
        //              height = 140,
        //              items= new List<Item>
        //              {
        //                  new Item
        //                  {
        //                      ware_key = "00055",
        //                      payment =  new Payment{value = 3000 },
        //                      name = "Товар",
        //                      cost = 300,
        //                      amount = 2,
        //                      weight = 700
        //                  },
        //              }
        //          }
        //      }
        //},
        //"eyJhbGciOiJSUzI1NiIsInR5cCI6IkpXVCJ9.eyJzY29wZSI6WyJvcmRlcjphbGwiLCJwYXltZW50OmFsbCJdLCJleHAiOjE2NzM1MzYzMjYsImF1dGhvcml0aWVzIjpbInNoYXJkLWlkOnJ1LTAxIiwiY2xpZW50LWNpdHk60J3QvtCy0L7RgdC40LHQuNGA0YHQuiwg0J3QvtCy0L7RgdC40LHQuNGA0YHQutCw0Y8g0L7QsdC70LDRgdGC0YwiLCJmdWxsLW5hbWU60KLQtdGB0YLQuNGA0L7QstCw0L3QuNC1INCY0L3RgtC10LPRgNCw0YbQuNC4INCY0JwsINCe0JHQqdCV0KHQotCS0J4g0KEg0J7Qk9Cg0JDQndCY0KfQldCd0J3QntCZINCe0KLQktCV0KLQodCi0JLQldCd0J3QntCh0KLQrNCuIiwiY29udHJhY3Q60JjQnC3QoNCkLdCT0JvQky0yMiIsImFjY291bnQtbGFuZzpydXMiLCJhY2NvdW50LXV1aWQ6ZTkyNWJkMGYtMDVhNi00YzU2LWI3MzctNGI5OWMxNGY2NjlhIiwiYXBpLXZlcnNpb246MS4xIiwiY2xpZW50LWlkLWVjNTplZDc1ZWNmNC0zMGVkLTQxNTMtYWZlOS1lYjgwYmI1MTJmMjIiLCJjbGllbnQtaWQtZWM0OjE0MzQ4MjMxIiwic29saWQtYWRkcmVzczpmYWxzZSIsImNvbnRyYWdlbnQtdXVpZDplZDc1ZWNmNC0zMGVkLTQxNTMtYWZlOS1lYjgwYmI1MTJmMjIiXSwianRpIjoiOWE4M2YwOGQtOTkxYy00OTBjLWJkOTAtNjIyN2Q5N2RlNWRkIiwiY2xpZW50X2lkIjoiRU1zY2Q2cjlKbkZpUTNiTG95akpZNmVNNzhKckpjZUkifQ.imN5Ytv_hnYAQCcAv-gKSS_0BsYJ-ygOq2S3oNr2FF0KNTX07NzyKoNRBsuqNjaefTo-1LSCLyBMvzKZLtn6dh21R6RS7fRyQfbq9Mbg_c_OXI_xf4kcs-2wrJZo5pnBIVtEs9tY8IB5Vzgof3m2pOgCkNoRgpIdnhAXugw0Z3fNniUnKVet9bYBs2n01VxEFYffGbnJOIV-giP6KORHT6PS7fYPj6sh8Y96eURnoNFdwXH2GkUa7FchL5qYwQqCYv0q4ctAfpPSLmfq237mL2muAWMUiGpucPqzMFEZQfnrB398iW-k9QARtC0G-7GNVw2eOO-1-0iwYiZnjK3lSw"
        //);
        //var res = Integration.GetOffices(new OfficesSearchParams { city_code = 44 }, "eyJhbGciOiJSUzI1NiIsInR5cCI6IkpXVCJ9.eyJzY29wZSI6WyJvcmRlcjphbGwiLCJwYXltZW50OmFsbCJdLCJleHAiOjE2NzM1MTg3NzcsImF1dGhvcml0aWVzIjpbInNoYXJkLWlkOnJ1LTAxIiwiY2xpZW50LWNpdHk60J3QvtCy0L7RgdC40LHQuNGA0YHQuiwg0J3QvtCy0L7RgdC40LHQuNGA0YHQutCw0Y8g0L7QsdC70LDRgdGC0YwiLCJmdWxsLW5hbWU60KLQtdGB0YLQuNGA0L7QstCw0L3QuNC1INCY0L3RgtC10LPRgNCw0YbQuNC4INCY0JwsINCe0JHQqdCV0KHQotCS0J4g0KEg0J7Qk9Cg0JDQndCY0KfQldCd0J3QntCZINCe0KLQktCV0KLQodCi0JLQldCd0J3QntCh0KLQrNCuIiwiY29udHJhY3Q60JjQnC3QoNCkLdCT0JvQky0yMiIsImFjY291bnQtbGFuZzpydXMiLCJhcGktdmVyc2lvbjoxLjEiLCJhY2NvdW50LXV1aWQ6ZTkyNWJkMGYtMDVhNi00YzU2LWI3MzctNGI5OWMxNGY2NjlhIiwiY2xpZW50LWlkLWVjNTplZDc1ZWNmNC0zMGVkLTQxNTMtYWZlOS1lYjgwYmI1MTJmMjIiLCJjbGllbnQtaWQtZWM0OjE0MzQ4MjMxIiwic29saWQtYWRkcmVzczpmYWxzZSIsImNvbnRyYWdlbnQtdXVpZDplZDc1ZWNmNC0zMGVkLTQxNTMtYWZlOS1lYjgwYmI1MTJmMjIiXSwianRpIjoiYzViMGI3NDktZDc5NS00OWZkLWFkZjQtNjAxOGIzNmQ5ZDE3IiwiY2xpZW50X2lkIjoiRU1zY2Q2cjlKbkZpUTNiTG95akpZNmVNNzhKckpjZUkifQ.ePxDZ5L519ZN8iTc-YLndJYtvrns8gCrycaG4Y3tl2T-pLQ39NeQqxPBY7xYF9Wbd-9UzB8QZPPQxdXxu-KG1JlqvFfxNA59_kt2loJ-mPDoEA0Ox-gjW9ZTzn6iAxAxVpNw2rxC1Mj1aDVBemk9isW2K_DqqzjnRLRnnXWECDqzDA2Y-ZqW6Y28_OaCDiTmdXItZ3QKTi_FSWBSXHJNYAUvFOxv_idWdD5P06-LXrcdDikPFzGBG2tz6bPu3ko-SYfnBz6W8h-iippuL3769QigCIA8a9bFbb5NfWCxPzPucKRPHz8fij9pDfWEMaKxYDPAhU0SKOg1-ALsKyw6Og");
        var res = Integration.GetOrderInfoByUuid("72753031-c4b3-4926-a80a-d961ef51105e", "eyJhbGciOiJSUzI1NiIsInR5cCI6IkpXVCJ9.eyJzY29wZSI6WyJvcmRlcjphbGwiLCJwYXltZW50OmFsbCJdLCJleHAiOjE2NzM1Mzc5NTgsImF1dGhvcml0aWVzIjpbInNoYXJkLWlkOnJ1LTAxIiwiY2xpZW50LWNpdHk60J3QvtCy0L7RgdC40LHQuNGA0YHQuiwg0J3QvtCy0L7RgdC40LHQuNGA0YHQutCw0Y8g0L7QsdC70LDRgdGC0YwiLCJmdWxsLW5hbWU60KLQtdGB0YLQuNGA0L7QstCw0L3QuNC1INCY0L3RgtC10LPRgNCw0YbQuNC4INCY0JwsINCe0JHQqdCV0KHQotCS0J4g0KEg0J7Qk9Cg0JDQndCY0KfQldCd0J3QntCZINCe0KLQktCV0KLQodCi0JLQldCd0J3QntCh0KLQrNCuIiwiY29udHJhY3Q60JjQnC3QoNCkLdCT0JvQky0yMiIsImFjY291bnQtbGFuZzpydXMiLCJhY2NvdW50LXV1aWQ6ZTkyNWJkMGYtMDVhNi00YzU2LWI3MzctNGI5OWMxNGY2NjlhIiwiYXBpLXZlcnNpb246MS4xIiwiY2xpZW50LWlkLWVjNTplZDc1ZWNmNC0zMGVkLTQxNTMtYWZlOS1lYjgwYmI1MTJmMjIiLCJjbGllbnQtaWQtZWM0OjE0MzQ4MjMxIiwiY29udHJhZ2VudC11dWlkOmVkNzVlY2Y0LTMwZWQtNDE1My1hZmU5LWViODBiYjUxMmYyMiIsInNvbGlkLWFkZHJlc3M6ZmFsc2UiXSwianRpIjoiZWIzMTU5NzYtYWVkMS00ZDBkLWIzZjMtNjQwNDEyZDg1OWZjIiwiY2xpZW50X2lkIjoiRU1zY2Q2cjlKbkZpUTNiTG95akpZNmVNNzhKckpjZUkifQ.FBnfyRedCT16kKrDTc4ylOnsRINKYB_CFgzB_BXpHzs2TbBI4PvtNCWczpqP3ZnNshEh8Ktq8-am6Y9jURpWnS-G3AN_k-S088_vMlXsaIr2vTDBY1KR_tlZ-V_TwLu-ChvOJFRdwwhasjrwZuv2c5QDLNzFCYS_PdJoNwZRqKoaOUpexKQH6GuxqeYW-fbFa94CryIsdR0KnzGmuf8fnxWrKDOkpKdJQp9V4Cl1LBaX5ot93otLo_n4ihnma5gR1mdHEAW-s8mWjsCF0eCpB2D1OT6d-aYG_xqlCVZoJqKOhfYektJddFMMZIZ8iL3mbk4thxez4StjOOIVXMXEDg");
    }
}
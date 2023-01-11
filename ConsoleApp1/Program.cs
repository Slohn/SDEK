using System.ComponentModel.DataAnnotations;
using System.Net.Http.Headers;
using System.Reflection;
using SDEK;
using SDEK.Models;

public class Test
{
    public static void Main(string[] args)
    {
        //Integration.Auth(new SDEK.Models.AuthDTO { grant_type = "client_credentials", 
        //    client_id = "EMscd6r9JnFiQ3bLoyjJY6eM78JrJceI",
        //    client_secret = "PjLZkKBHEiLK3YsjtNrt3TGNG0ahs3kG" });
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
        Integration.OrderUpdate(new OrderDTO
        {
            uuid = "72753031-9bf3-41dc-ace7-a33e50dc28f5",
            Tariff_code = 119,
            Shipment_point = "MSK69",
            Sender = new Sender
            {
                company = "Компания",
                name = "Петров Петр",
                email = "msk@cdek.ru",
                phones = new List<Phone>
                {
                    new Phone {number = "+79134000101" }
                }
            },
            Recipient = new Recipient
            {
                name = "Иванов Иван",
                company = "Иванов Иван",
                phones = new List<Phone>
                {
                    new Phone {number = "+79134000404" }
                }
            },
            ToLocation = new ToLocation
            {
                address = "ул. Блюхера, 32",

            },
            Services = new List<Service> {
                new Service { code = "INSURANCE" }
            },
            Packages = new List<Package>
            {
                new Package
                {
                    number = "bar-001",
                    weight = 1000,
                    length = 10,
                    width = 140,
                    height = 140,
                    items= new List<Item>
                    {
                        new Item
                        {
                            ware_key = "00055",
                            payment =  new Payment{value = 3000 },
                            name = "Товар",
                            cost = 300,
                            amount = 2,
                            weight = 700
                        },
                    }
                }
            }
        },
        "eyJhbGciOiJSUzI1NiIsInR5cCI6IkpXVCJ9.eyJzY29wZSI6WyJvcmRlcjphbGwiLCJwYXltZW50OmFsbCJdLCJleHAiOjE2NzM0NDg2ODAsImF1dGhvcml0aWVzIjpbInNoYXJkLWlkOnJ1LTAxIiwiY2xpZW50LWNpdHk60J3QvtCy0L7RgdC40LHQuNGA0YHQuiwg0J3QvtCy0L7RgdC40LHQuNGA0YHQutCw0Y8g0L7QsdC70LDRgdGC0YwiLCJmdWxsLW5hbWU60KLQtdGB0YLQuNGA0L7QstCw0L3QuNC1INCY0L3RgtC10LPRgNCw0YbQuNC4INCY0JwsINCe0JHQqdCV0KHQotCS0J4g0KEg0J7Qk9Cg0JDQndCY0KfQldCd0J3QntCZINCe0KLQktCV0KLQodCi0JLQldCd0J3QntCh0KLQrNCuIiwiYWNjb3VudC1sYW5nOnJ1cyIsImNvbnRyYWN0OtCY0Jwt0KDQpC3Qk9Cb0JMtMjIiLCJhcGktdmVyc2lvbjoxLjEiLCJhY2NvdW50LXV1aWQ6ZTkyNWJkMGYtMDVhNi00YzU2LWI3MzctNGI5OWMxNGY2NjlhIiwiY2xpZW50LWlkLWVjNTplZDc1ZWNmNC0zMGVkLTQxNTMtYWZlOS1lYjgwYmI1MTJmMjIiLCJjbGllbnQtaWQtZWM0OjE0MzQ4MjMxIiwiY29udHJhZ2VudC11dWlkOmVkNzVlY2Y0LTMwZWQtNDE1My1hZmU5LWViODBiYjUxMmYyMiIsInNvbGlkLWFkZHJlc3M6ZmFsc2UiXSwianRpIjoiMmZjNDM2NzAtNTBmZS00M2I0LWJiNDAtNmVmM2VmMjNmN2Q3IiwiY2xpZW50X2lkIjoiRU1zY2Q2cjlKbkZpUTNiTG95akpZNmVNNzhKckpjZUkifQ.NbPkQR1q8IymiGWr8eyO9voE2dAEtIRUeXQYuA5o7-p0u4KJoYuAyA9usym4ofzfEgKxtqxy4oZinYe4ZNXAxbNGwFJ6wKTsLevMTFS95aWU_-5vLV7_9oACuOSSQM4QDWzosRx9tL1aKYTygKHE9YFnGQqEf377tgF1p39yYXjUtvUZbBboZA3p1-8JS15sVn7THNH7U0lBINE_jKkZnST0f4xCejkuchOfIPCyA9k9O457PY-vSDcxpu7Cd44aOztPVh0GG1nSY-jsb7S070EM4kg_TkERFGd2LW74RS9v5Yh2WzVGQhqemv37cmap6ykE5OKR4wCwaGdf4H1zOw"
       );

    }
}
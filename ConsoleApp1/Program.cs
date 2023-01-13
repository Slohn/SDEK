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

        //Integration.GetOrderInfoByUuid("72753031-4378-416e-ae44-1ef3e875ef92");

        //var res = Integration.DeleteOrder("72753031-5100-4328-a116-e4e400ce0df3", "eyJhbGciOiJSUzI1NiIsInR5cCI6IkpXVCJ9.eyJzY29wZSI6WyJvcmRlcjphbGwiLCJwYXltZW50OmFsbCJdLCJleHAiOjE2NzM1OTk0ODYsImF1dGhvcml0aWVzIjpbInNoYXJkLWlkOnJ1LTAxIiwiY2xpZW50LWNpdHk60J3QvtCy0L7RgdC40LHQuNGA0YHQuiwg0J3QvtCy0L7RgdC40LHQuNGA0YHQutCw0Y8g0L7QsdC70LDRgdGC0YwiLCJmdWxsLW5hbWU60KLQtdGB0YLQuNGA0L7QstCw0L3QuNC1INCY0L3RgtC10LPRgNCw0YbQuNC4INCY0JwsINCe0JHQqdCV0KHQotCS0J4g0KEg0J7Qk9Cg0JDQndCY0KfQldCd0J3QntCZINCe0KLQktCV0KLQodCi0JLQldCd0J3QntCh0KLQrNCuIiwiYWNjb3VudC1sYW5nOnJ1cyIsImNvbnRyYWN0OtCY0Jwt0KDQpC3Qk9Cb0JMtMjIiLCJhY2NvdW50LXV1aWQ6ZTkyNWJkMGYtMDVhNi00YzU2LWI3MzctNGI5OWMxNGY2NjlhIiwiYXBpLXZlcnNpb246MS4xIiwiY2xpZW50LWlkLWVjNTplZDc1ZWNmNC0zMGVkLTQxNTMtYWZlOS1lYjgwYmI1MTJmMjIiLCJjbGllbnQtaWQtZWM0OjE0MzQ4MjMxIiwiY29udHJhZ2VudC11dWlkOmVkNzVlY2Y0LTMwZWQtNDE1My1hZmU5LWViODBiYjUxMmYyMiIsInNvbGlkLWFkZHJlc3M6ZmFsc2UiXSwianRpIjoiZDQ4ODhjNTgtNzk5MS00NjM0LWExZTUtZmIzY2M1YjAxNDRmIiwiY2xpZW50X2lkIjoiRU1zY2Q2cjlKbkZpUTNiTG95akpZNmVNNzhKckpjZUkifQ.hrEkQnEkJGjbSL4cNrX0AEo8TaYUqaiTNihOiHeHk3VO2TIJYw65oPCxnuea3PVhjoHzOUc12_4HCy3dP2aKNfUdiIdJv-L2wGDHVozwVnH81wRuMT90aE6wrKxoNHR8o3fot8OTvlC-tbNMrkLvN2CBn6JajxxpLQQ_eE5TxU3mnSuzjDEW3voMuLOE_PyWS7TjfK06O6JXnNhegkKdWxmR_muh80oIxp55ocMxks6B36L90dc3rGPtN-QIyfxMmNfcecdtDlnHkyHrs6rnS5_cbJJiNxj3QpiEHygBmj2Tbflq1T06tZtuAuylTWy-q4-C4fspaCV6bnz3wl2iKQ");
        //var res = Integration.RefusalReg("72753031-4378-416e-ae44-1ef3e875ef92", "eyJhbGciOiJSUzI1NiIsInR5cCI6IkpXVCJ9.eyJzY29wZSI6WyJvcmRlcjphbGwiLCJwYXltZW50OmFsbCJdLCJleHAiOjE2NzM2MDMzNjAsImF1dGhvcml0aWVzIjpbInNoYXJkLWlkOnJ1LTAxIiwiY2xpZW50LWNpdHk60J3QvtCy0L7RgdC40LHQuNGA0YHQuiwg0J3QvtCy0L7RgdC40LHQuNGA0YHQutCw0Y8g0L7QsdC70LDRgdGC0YwiLCJmdWxsLW5hbWU60KLQtdGB0YLQuNGA0L7QstCw0L3QuNC1INCY0L3RgtC10LPRgNCw0YbQuNC4INCY0JwsINCe0JHQqdCV0KHQotCS0J4g0KEg0J7Qk9Cg0JDQndCY0KfQldCd0J3QntCZINCe0KLQktCV0KLQodCi0JLQldCd0J3QntCh0KLQrNCuIiwiY29udHJhY3Q60JjQnC3QoNCkLdCT0JvQky0yMiIsImFjY291bnQtbGFuZzpydXMiLCJhcGktdmVyc2lvbjoxLjEiLCJhY2NvdW50LXV1aWQ6ZTkyNWJkMGYtMDVhNi00YzU2LWI3MzctNGI5OWMxNGY2NjlhIiwiY2xpZW50LWlkLWVjNTplZDc1ZWNmNC0zMGVkLTQxNTMtYWZlOS1lYjgwYmI1MTJmMjIiLCJjbGllbnQtaWQtZWM0OjE0MzQ4MjMxIiwic29saWQtYWRkcmVzczpmYWxzZSIsImNvbnRyYWdlbnQtdXVpZDplZDc1ZWNmNC0zMGVkLTQxNTMtYWZlOS1lYjgwYmI1MTJmMjIiXSwianRpIjoiOGI1OTEyMGItZGEyMi00NGJhLThhZGYtY2E5YTZmNzAyMGJkIiwiY2xpZW50X2lkIjoiRU1zY2Q2cjlKbkZpUTNiTG95akpZNmVNNzhKckpjZUkifQ.DZimFok_sKAdxhDkF3XR0UVMvePJ0scMEOLmZvu4ZufxJuucbwqGcyHM5hEtSTvc_w9JB8yGPiLXZsl6_tXIbgPzWAUvDX5WVBub0bt9_LEROr4mDkOo-n8krripHZNKvri6e_g7XQXUCanN9RR3AAwpqmuv2sfQ5GkreS_kZcrfcKRtOt8NPpWssRnhwpr16e8hXkIr9N2skXPocvlC8uU5G_rqAhxDz8cKCtMJjziij38fG2CfXmaOw9XlK-_Cs1IY78RHRXEGlhhrVucFjtZ5boB34ziz4ka12fnlBYvMxblgdV31Tw_2mUozg22aQDXFNUF5at7Pi5otE_JbeQ");
        //Integration.GetAllOffices("eyJhbGciOiJSUzI1NiIsInR5cCI6IkpXVCJ9.eyJzY29wZSI6WyJvcmRlcjphbGwiLCJwYXltZW50OmFsbCJdLCJleHAiOjE2NzM0NDM5NDUsImF1dGhvcml0aWVzIjpbInNoYXJkLWlkOnJ1LTAxIiwiY2xpZW50LWNpdHk60J3QvtCy0L7RgdC40LHQuNGA0YHQuiwg0J3QvtCy0L7RgdC40LHQuNGA0YHQutCw0Y8g0L7QsdC70LDRgdGC0YwiLCJmdWxsLW5hbWU60KLQtdGB0YLQuNGA0L7QstCw0L3QuNC1INCY0L3RgtC10LPRgNCw0YbQuNC4INCY0JwsINCe0JHQqdCV0KHQotCS0J4g0KEg0J7Qk9Cg0JDQndCY0KfQldCd0J3QntCZINCe0KLQktCV0KLQodCi0JLQldCd0J3QntCh0KLQrNCuIiwiYWNjb3VudC1sYW5nOnJ1cyIsImNvbnRyYWN0OtCY0Jwt0KDQpC3Qk9Cb0JMtMjIiLCJhcGktdmVyc2lvbjoxLjEiLCJhY2NvdW50LXV1aWQ6ZTkyNWJkMGYtMDVhNi00YzU2LWI3MzctNGI5OWMxNGY2NjlhIiwiY2xpZW50LWlkLWVjNTplZDc1ZWNmNC0zMGVkLTQxNTMtYWZlOS1lYjgwYmI1MTJmMjIiLCJjbGllbnQtaWQtZWM0OjE0MzQ4MjMxIiwic29saWQtYWRkcmVzczpmYWxzZSIsImNvbnRyYWdlbnQtdXVpZDplZDc1ZWNmNC0zMGVkLTQxNTMtYWZlOS1lYjgwYmI1MTJmMjIiXSwianRpIjoiZDkyNzZhMjMtYTdhZi00NTY2LWFiYzYtZjk1MzFmMWZjNGZhIiwiY2xpZW50X2lkIjoiRU1zY2Q2cjlKbkZpUTNiTG95akpZNmVNNzhKckpjZUkifQ.Oi8gyq1-Pk6AwrRMTPCIMiF6itYjLZZWGGyDqQhXDX7SgF6Px9r4qznVklyPqH2SVjLS1A8dRbhXTCZAhoMdEq7Wz5u3FBACXv5WSP0-lix8c0UcXEvj-42ltZjihBh_WMvRDnqnH5ZYKVCjp6LDA1qgGic7mNAm4vowrYH_d4RhfP7dQw2b7e_SBUZdd08mBB_f_5VPGtq-1EmlLg6pcl25EbfnqebtgFvmCHHQhOopd1L9m27T_ahZ91QcMwFgopX0-Qm2ljm_gH-JG1szxGQ1pOQlUg_C4VBOSjff3IsosMbAH_CamvH7jNXyzLKgVkLtcWkKtmdhWvPN17gkFw");
        //var res = Integration.OrderUpdate(new OrderDTO
        //{
        //    uuid = "72753031-4378-416e-ae44-1ef3e875ef92",
        //    //Tariff_code = 119,
        //    comment = "hahahahahhah",
        //    Shipment_point = "MSK67"
        //    //Sender = new Sender
        //    //{
        //    //    company = "Компания",
        //    //    name = "Петров Петр",
        //    //    email = "msk@cdek.ru",
        //    //    phones = new List<Phone>
        //    //      {
        //    //          new Phone {number = "+79134000101" }
        //    //      }
        //    //},
        //    //Recipient = new Recipient
        //    //{
        //    //    name = "Петров Петр",
        //    //    company = "Петров Петр",
        //    //    phones = new List<Phone>
        //    //      {
        //    //          new Phone {number = "+79134000404" }
        //    //      }
        //    //},
        //    //ToLocation = new ToLocation
        //    //{
        //    //    address = "ул. Московская , 32 ",

        //    //},
        //    //Services = new List<Service> {
        //    //      new Service { code = "INSURANCE" }
        //    //  },
        //    //Packages = new List<Package>
        //    //  {
        //    //      new Package
        //    //      {
        //    //          number = "bar-001",
        //    //          weight = 1000,
        //    //          length = 10,
        //    //          width = 140,
        //    //          height = 140,
        //    //          package_id = "be9cf8a1-aaea-45bd-a165-bec49b27204f",
        //    //          items= new List<Item>
        //    //          {
        //    //              new Item
        //    //              {
        //    //                  ware_key = "00055",
        //    //                  payment =  new Payment{value = 3000 },
        //    //                  name = "Товар",
        //    //                  cost = 300,
        //    //                  amount = 2,
        //    //                  weight = 700
        //    //              },
        //    //          }
        //    //      }
        //    //  }
        //},
        //"eyJhbGciOiJSUzI1NiIsInR5cCI6IkpXVCJ9.eyJzY29wZSI6WyJvcmRlcjphbGwiLCJwYXltZW50OmFsbCJdLCJleHAiOjE2NzM2MDMzNjAsImF1dGhvcml0aWVzIjpbInNoYXJkLWlkOnJ1LTAxIiwiY2xpZW50LWNpdHk60J3QvtCy0L7RgdC40LHQuNGA0YHQuiwg0J3QvtCy0L7RgdC40LHQuNGA0YHQutCw0Y8g0L7QsdC70LDRgdGC0YwiLCJmdWxsLW5hbWU60KLQtdGB0YLQuNGA0L7QstCw0L3QuNC1INCY0L3RgtC10LPRgNCw0YbQuNC4INCY0JwsINCe0JHQqdCV0KHQotCS0J4g0KEg0J7Qk9Cg0JDQndCY0KfQldCd0J3QntCZINCe0KLQktCV0KLQodCi0JLQldCd0J3QntCh0KLQrNCuIiwiY29udHJhY3Q60JjQnC3QoNCkLdCT0JvQky0yMiIsImFjY291bnQtbGFuZzpydXMiLCJhcGktdmVyc2lvbjoxLjEiLCJhY2NvdW50LXV1aWQ6ZTkyNWJkMGYtMDVhNi00YzU2LWI3MzctNGI5OWMxNGY2NjlhIiwiY2xpZW50LWlkLWVjNTplZDc1ZWNmNC0zMGVkLTQxNTMtYWZlOS1lYjgwYmI1MTJmMjIiLCJjbGllbnQtaWQtZWM0OjE0MzQ4MjMxIiwic29saWQtYWRkcmVzczpmYWxzZSIsImNvbnRyYWdlbnQtdXVpZDplZDc1ZWNmNC0zMGVkLTQxNTMtYWZlOS1lYjgwYmI1MTJmMjIiXSwianRpIjoiOGI1OTEyMGItZGEyMi00NGJhLThhZGYtY2E5YTZmNzAyMGJkIiwiY2xpZW50X2lkIjoiRU1zY2Q2cjlKbkZpUTNiTG95akpZNmVNNzhKckpjZUkifQ.DZimFok_sKAdxhDkF3XR0UVMvePJ0scMEOLmZvu4ZufxJuucbwqGcyHM5hEtSTvc_w9JB8yGPiLXZsl6_tXIbgPzWAUvDX5WVBub0bt9_LEROr4mDkOo-n8krripHZNKvri6e_g7XQXUCanN9RR3AAwpqmuv2sfQ5GkreS_kZcrfcKRtOt8NPpWssRnhwpr16e8hXkIr9N2skXPocvlC8uU5G_rqAhxDz8cKCtMJjziij38fG2CfXmaOw9XlK-_Cs1IY78RHRXEGlhhrVucFjtZ5boB34ziz4ka12fnlBYvMxblgdV31Tw_2mUozg22aQDXFNUF5at7Pi5otE_JbeQ"
        //);
        //var res = Integration.GetOffices(new OfficesSearchParams { city_code = 44 }, "eyJhbGciOiJSUzI1NiIsInR5cCI6IkpXVCJ9.eyJzY29wZSI6WyJvcmRlcjphbGwiLCJwYXltZW50OmFsbCJdLCJleHAiOjE2NzM1MTg3NzcsImF1dGhvcml0aWVzIjpbInNoYXJkLWlkOnJ1LTAxIiwiY2xpZW50LWNpdHk60J3QvtCy0L7RgdC40LHQuNGA0YHQuiwg0J3QvtCy0L7RgdC40LHQuNGA0YHQutCw0Y8g0L7QsdC70LDRgdGC0YwiLCJmdWxsLW5hbWU60KLQtdGB0YLQuNGA0L7QstCw0L3QuNC1INCY0L3RgtC10LPRgNCw0YbQuNC4INCY0JwsINCe0JHQqdCV0KHQotCS0J4g0KEg0J7Qk9Cg0JDQndCY0KfQldCd0J3QntCZINCe0KLQktCV0KLQodCi0JLQldCd0J3QntCh0KLQrNCuIiwiY29udHJhY3Q60JjQnC3QoNCkLdCT0JvQky0yMiIsImFjY291bnQtbGFuZzpydXMiLCJhcGktdmVyc2lvbjoxLjEiLCJhY2NvdW50LXV1aWQ6ZTkyNWJkMGYtMDVhNi00YzU2LWI3MzctNGI5OWMxNGY2NjlhIiwiY2xpZW50LWlkLWVjNTplZDc1ZWNmNC0zMGVkLTQxNTMtYWZlOS1lYjgwYmI1MTJmMjIiLCJjbGllbnQtaWQtZWM0OjE0MzQ4MjMxIiwic29saWQtYWRkcmVzczpmYWxzZSIsImNvbnRyYWdlbnQtdXVpZDplZDc1ZWNmNC0zMGVkLTQxNTMtYWZlOS1lYjgwYmI1MTJmMjIiXSwianRpIjoiYzViMGI3NDktZDc5NS00OWZkLWFkZjQtNjAxOGIzNmQ5ZDE3IiwiY2xpZW50X2lkIjoiRU1zY2Q2cjlKbkZpUTNiTG95akpZNmVNNzhKckpjZUkifQ.ePxDZ5L519ZN8iTc-YLndJYtvrns8gCrycaG4Y3tl2T-pLQ39NeQqxPBY7xYF9Wbd-9UzB8QZPPQxdXxu-KG1JlqvFfxNA59_kt2loJ-mPDoEA0Ox-gjW9ZTzn6iAxAxVpNw2rxC1Mj1aDVBemk9isW2K_DqqzjnRLRnnXWECDqzDA2Y-ZqW6Y28_OaCDiTmdXItZ3QKTi_FSWBSXHJNYAUvFOxv_idWdD5P06-LXrcdDikPFzGBG2tz6bPu3ko-SYfnBz6W8h-iippuL3769QigCIA8a9bFbb5NfWCxPzPucKRPHz8fij9pDfWEMaKxYDPAhU0SKOg1-ALsKyw6Og");
        //var res = Integration.GetOrderInfoByUuid("72753031-4378-416e-ae44-1ef3e875ef92", "eyJhbGciOiJSUzI1NiIsInR5cCI6IkpXVCJ9.eyJzY29wZSI6WyJvcmRlcjphbGwiLCJwYXltZW50OmFsbCJdLCJleHAiOjE2NzM2MDMzNjAsImF1dGhvcml0aWVzIjpbInNoYXJkLWlkOnJ1LTAxIiwiY2xpZW50LWNpdHk60J3QvtCy0L7RgdC40LHQuNGA0YHQuiwg0J3QvtCy0L7RgdC40LHQuNGA0YHQutCw0Y8g0L7QsdC70LDRgdGC0YwiLCJmdWxsLW5hbWU60KLQtdGB0YLQuNGA0L7QstCw0L3QuNC1INCY0L3RgtC10LPRgNCw0YbQuNC4INCY0JwsINCe0JHQqdCV0KHQotCS0J4g0KEg0J7Qk9Cg0JDQndCY0KfQldCd0J3QntCZINCe0KLQktCV0KLQodCi0JLQldCd0J3QntCh0KLQrNCuIiwiY29udHJhY3Q60JjQnC3QoNCkLdCT0JvQky0yMiIsImFjY291bnQtbGFuZzpydXMiLCJhcGktdmVyc2lvbjoxLjEiLCJhY2NvdW50LXV1aWQ6ZTkyNWJkMGYtMDVhNi00YzU2LWI3MzctNGI5OWMxNGY2NjlhIiwiY2xpZW50LWlkLWVjNTplZDc1ZWNmNC0zMGVkLTQxNTMtYWZlOS1lYjgwYmI1MTJmMjIiLCJjbGllbnQtaWQtZWM0OjE0MzQ4MjMxIiwic29saWQtYWRkcmVzczpmYWxzZSIsImNvbnRyYWdlbnQtdXVpZDplZDc1ZWNmNC0zMGVkLTQxNTMtYWZlOS1lYjgwYmI1MTJmMjIiXSwianRpIjoiOGI1OTEyMGItZGEyMi00NGJhLThhZGYtY2E5YTZmNzAyMGJkIiwiY2xpZW50X2lkIjoiRU1zY2Q2cjlKbkZpUTNiTG95akpZNmVNNzhKckpjZUkifQ.DZimFok_sKAdxhDkF3XR0UVMvePJ0scMEOLmZvu4ZufxJuucbwqGcyHM5hEtSTvc_w9JB8yGPiLXZsl6_tXIbgPzWAUvDX5WVBub0bt9_LEROr4mDkOo-n8krripHZNKvri6e_g7XQXUCanN9RR3AAwpqmuv2sfQ5GkreS_kZcrfcKRtOt8NPpWssRnhwpr16e8hXkIr9N2skXPocvlC8uU5G_rqAhxDz8cKCtMJjziij38fG2CfXmaOw9XlK-_Cs1IY78RHRXEGlhhrVucFjtZ5boB34ziz4ka12fnlBYvMxblgdV31Tw_2mUozg22aQDXFNUF5at7Pi5otE_JbeQ");
    }
}
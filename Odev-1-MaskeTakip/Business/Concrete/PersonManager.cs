using Business.Abstract;
using Entities.Concrete;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete;

public class PersonManager : IApplicantService
{
    public void ApplyForMask(Person person)
    {
        if (CheckPerson(person))
        {
            Console.WriteLine($"{person.FirstName} {person.LastName} için maske başvurusu yapıldı.");
        }
        else
        {
            Console.WriteLine($"{person.FirstName} {person.LastName} için maske başvurusu yapılamadı!");
        }
    }

    public List<Person> GetList()
    {
        return null;
    }

    //https://tckimlik.nvi.gov.tr/Service/KPSPublic.asmx
    public bool CheckPerson(Person person)
    {
        KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

        return client.TCKimlikNoDogrulaAsync(
            new TCKimlikNoDogrulaRequest(
                new TCKimlikNoDogrulaRequestBody(person.NationalIdentity, person.FirstName, person.LastName, person.DateOfBirthYear))).Result.Body.TCKimlikNoDogrulaResult;
    }
}

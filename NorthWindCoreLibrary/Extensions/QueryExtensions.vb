Imports Microsoft.EntityFrameworkCore
Imports NorthWindCoreLibrary.Models
Imports NorthWindCoreLibrary_vb.Models

Namespace Extensions

    Public Module QueryExtensions

        ''' <summary>
        ''' Include <see cref="Models.Country"/> <see cref="Models.Contact"/> and <see cref="Models.ContactDevice"/> navigation
        ''' </summary>
        ''' <param name="query"></param>
        ''' <returns><see cref="IQueryable(Of Customer)"/></returns>
        <Runtime.CompilerServices.Extension>
        Public Function IncludeContactsDevicesCountry(query As IQueryable(Of Customer)) As IQueryable(Of Customer)
            Return query.Include(Function(customer) customer.CountryIdentifierNavigation).Include(
                Function(customer) customer.Contact).ThenInclude(Function(contact) contact.ContactDevices)
        End Function

    End Module
End Namespace
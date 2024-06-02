using DomainLayer;

namespace ApplicationLayer;

public class CreateMovieDto
{
    public required string Title { get; set; }
    public required string Director { get; set; }
    public required string ReleaseDate { get; set; }

    //Stworzenie dto dla photo do tego formularzu + konfiguracja całego blob storage
    //Create movie zawiera dane + dynamicze dodawanie WASM zdjec (formularz w formularzu)
    //Wybieranie coś na wzór enum Category plus Genre 
    //Trailer dodawany bezpośrednio w widokufilmu  (dodanie sekcji) ??  Nullable dla trailer ?? 
    //Trailer dodawany  w formularzu poprzez link youtube WASM napisanie metody pobierajacej z api YT i umeiszczajacy miniature.
    //Kategorie pobiore z dbcotextu nastepnie uzytkownik bedzie mógł wybraćkategorie 
    //po czym zosatnie zwrócone GenreId i przypisane do modelu
}

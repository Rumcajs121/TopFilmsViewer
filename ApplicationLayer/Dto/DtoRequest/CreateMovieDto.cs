using DomainLayer;

namespace ApplicationLayer;
public class CreateMovieDto
{
    public string Title { get; set; }
    public string Director { get; set; }
    public string  Description { get; set; }
    public string ReleaseDate { get; set; }
    public List<PhotoDto> Photos { get; set; }
    public TrailerDto Trailer { get; set; }
    public int GenreId { get; set; } //Wybierane z form
    public int StudioId { get; set; } //Wybierane z form
}

public class PhotoDto
{
    public string Uri { get; set; }
    // inne właściwości
}

public class TrailerDto
{
    public string Url { get; set; }
    // inne właściwości
}
    //Stworzenie dto dla photo do tego formularzu + konfiguracja całego blob storage
    //Create movie zawiera dane + dynamicze dodawanie WASM zdjec (formularz w formularzu)
    //Wybieranie coś na wzór enum Category plus Genre 
    //Trailer dodawany bezpośrednio w widokufilmu  (dodanie sekcji) ??  Nullable dla trailer ?? 
    //Trailer dodawany  w formularzu poprzez link youtube WASM napisanie metody pobierajacej z api YT i umeiszczajacy miniature.
    //Kategorie pobiore z dbcotextu nastepnie uzytkownik bedzie mógł wybraćkategorie 
    //po czym zosatnie zwrócone GenreId i przypisane do modelu
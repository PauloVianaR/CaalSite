namespace CaalSite.Content;

/// <summary>
/// Fonte única de conteúdo e imagens do site. Para adicionar uma foto à galeria,
/// salve o arquivo em wwwroot/images/gallery e cadastre somente um novo MediaItem.
/// </summary>
public static class SiteContent
{
    public const string WhatsAppNumber = "5531982608540";
    public const string PhoneDisplay = "(31) 98260-8540";
    public const string Address = "Rua Amélia Augusta do Nascimento, 24 · Jardim Brasília · Betim/MG";
    public const string MapsUrl = "https://maps.app.goo.gl/JQEt8v7VXzqyCsE3A";
    public const string BrandDarkLogo = "/images/brand/logo-dark.png";
    public const string BrandLightLogo = "/images/brand/logo-light.png";

    public static readonly MediaItem Hero = new(
        "/images/gallery/arte-01.jpg",
        "Bailarinas do Centro de Artes Almira Lopes em uma composição contemporânea",
        "Hero",
        "Onde a arte ganha vida",
        "Formação artística com excelência, disciplina e acolhimento.",
        974,
        793,
        "landscape",
        "58% center");

    public static readonly MediaItem About = new(
        "/images/gallery/arte-07.jpg",
        "Elenco do CAAL celebrando junto no palco",
        "História",
        "18 anos inspirando artistas em Betim",
        "Uma família artística construída em movimento.",
        850,
        853,
        "square",
        "center 28%");

    public static readonly MediaItem FinalCta = new(
        "/images/gallery/arte-05.jpg",
        "Elenco do CAAL reunido no palco",
        "Família CAAL",
        "Venha fazer parte da nossa família artística",
        "Uma aula pode ser o começo de uma nova história.",
        1193,
        707,
        "landscape",
        "center");

    public static string WhatsAppUrl(string message) =>
        $"https://wa.me/{WhatsAppNumber}?text={Uri.EscapeDataString(message)}";

    public static readonly IReadOnlyList<FeatureItem> Features =
    [
        new("18", "anos de história", "Uma trajetória dedicada à cultura e à formação artística em Betim.", "01"),
        new("02", "salas de dança", "Ambientes preparados para movimento, técnica, segurança e criação.", "02"),
        new("01", "palco próprio", "Um espaço onde o aprendizado encontra a emoção de estar em cena.", "03"),
        new("∞", "possibilidades", "Professores especializados, todas as idades e arte que transforma.", "04"),
        new("CA", "Arte & animação", "Personagens vivos e experiências especiais para festas e celebrações.", "05")
    ];

    public static readonly IReadOnlyList<CourseItem> Courses =
    [
        new("baby-ballet", "Baby Ballet", "Primeiros passos com afeto, musicalidade e descoberta do corpo.", "A partir da primeira infância", "/images/gallery/arte-10.jpg", "center 30%", "BB"),
        new("ballet-infantil", "Ballet Clássico Infantil", "Base técnica, postura e delicadeza para crescer dançando.", "Infantil", "/images/gallery/arte-13.jpg", "center 40%", "BI"),
        new("ballet-adulto", "Ballet Clássico Adulto", "Técnica e expressão em um ambiente respeitoso e acolhedor.", "Jovens e adultos", "/images/gallery/arte-11.jpg", "center 35%", "BA"),
        new("jazz-infantil", "Jazz Dance Infantil", "Energia, coordenação e presença de palco em cada sequência.", "Infantil", "/images/gallery/arte-04.jpg", "center 35%", "JI"),
        new("jazz-adulto", "Jazz Dance Adulto", "Movimento, confiança e performance para dançar sem limites.", "Jovens e adultos", "/images/gallery/arte-14.jpg", "center 35%", "JA"),
        new("contemporaneo", "Contemporâneo", "Liberdade de criação, consciência corporal e emoção em movimento.", "Diversos níveis", "/images/gallery/arte-01.jpg", "center 48%", "CO"),
        new("passinhos", "Passinhos dos Anos 80", "Ritmo, memória afetiva e muita diversão em uma aula vibrante.", "Adulto", "/images/gallery/arte-03.jpg", "center 45%", "80"),
        new("pontas", "Técnica de Pontas", "Preparação cuidadosa para força, precisão e leveza sobre as pontas.", "Nível técnico indicado", "/images/gallery/arte-02.jpg", "center 45%", "TP"),
        new("flamenco", "Flamenco", "Força, musicalidade e personalidade na intensidade da dança espanhola.", "Diversos níveis", "/images/gallery/arte-09.jpg", "center 40%", "FL"),
        new("teatro", "Teatro", "Imaginação, voz e presença para contar histórias e ocupar o palco.", "Todas as idades", "/images/gallery/arte-06.jpg", "center 35%", "TE"),
        new("danca-cigana", "Dança Cigana", "Fluidez, expressão e celebração em uma dança cheia de significado.", "Diversos níveis", "/images/gallery/arte-12.jpg", "center 35%", "DC")
    ];

    public static readonly IReadOnlyList<MediaItem> Structure =
    [
        new("/images/gallery/arte-10.jpg", "Turma infantil com professoras em uma das salas do CAAL", "Estrutura", "Salas que acolhem", "Duas salas preparadas para aprender, experimentar e criar.", 720, 714, "structure-tall", "center"),
        new("/images/gallery/arte-05.jpg", "Elenco do CAAL reunido no palco diante do público", "Estrutura", "Arte que encontra o público", "Apresentações que transformam técnica em memória.", 1193, 707, "structure-wide", "center"),
        new("/images/gallery/arte-06.jpg", "Espetáculo colorido do CAAL em palco próprio", "Estrutura", "Um palco para crescer", "Ensaiar, criar e viver a experiência completa de estar em cena.", 1323, 633, "structure-wide", "center")
    ];

    public static readonly IReadOnlyList<MediaItem> Awards =
    [
        new("/images/gallery/trofeus.jpg", "Parede do CAAL com troféus conquistados em festivais e competições", "Conquistas", "Uma história que se vê", "Troféus de diferentes festivais contam anos de disciplina e entrega.", 1599, 899, "landscape", "center"),
        new("/images/gallery/medalhas.jpg", "Medalhas de competições conquistadas por alunos do CAAL", "Conquistas", "Cada medalha, um caminho", "Resultados que começam muito antes do palco, dentro de cada aula.", 884, 1600, "portrait", "center")
    ];

    public static readonly IReadOnlyList<string> GalleryFilters =
        ["Todos", "Espetáculos", "Aulas", "Competições", "Conquistas"];

    public static readonly IReadOnlyList<MediaItem> Gallery =
    [
        new("/images/gallery/arte-02.jpg", "Bailarina do CAAL ensaiando em um espaço iluminado", "Aulas", "Entre luz e movimento", "A técnica encontra a personalidade de cada artista.", 711, 765, "portrait", "center"),
        new("/images/gallery/arte-05.jpg", "Grande elenco do CAAL reunido no palco após espetáculo", "Espetáculos", "Nossa família em cena", "O instante em que palco, elenco e público se tornam um só.", 1193, 707, "landscape", "center"),
        new("/images/gallery/arte-12.jpg", "Intérprete em cena com composição coreográfica de múltiplos braços", "Espetáculos", "Presença", "Expressão, precisão e narrativa em cada gesto.", 720, 898, "portrait", "center"),
        new("/images/gallery/arte-08.jpg", "Elenco em espetáculo inspirado na savana", "Espetáculos", "Histórias dançadas", "Cenários e corpos criando outros mundos.", 720, 465, "landscape", "center"),
        new("/images/gallery/arte-04.jpg", "Bailarina jovem executando arabesque em competição", "Competições", "Disciplina que floresce", "Coragem e preparo para ocupar qualquer palco.", 898, 734, "landscape", "center"),
        new("/images/gallery/arte-03.jpg", "Dupla de dança executando movimento acrobático", "Aulas", "Confiança em movimento", "Parceria, escuta e força construídas em conjunto.", 634, 676, "portrait", "center"),
        new("/images/gallery/arte-09.jpg", "Grupo de bailarinas em figurinos vermelhos durante espetáculo", "Espetáculos", "Intensidade", "A emoção toma forma no palco.", 720, 474, "landscape", "center"),
        new("/images/gallery/arte-13.jpg", "Bailarina de vermelho em salto durante apresentação", "Competições", "O voo", "Técnica, impulso e a liberdade de ir além.", 720, 889, "portrait", "center"),
        new("/images/gallery/arte-10.jpg", "Turma de Baby Ballet sorrindo após aula", "Aulas", "Alegria desde o começo", "Uma iniciação artística cercada de cuidado.", 720, 714, "square", "center"),
        new("/images/gallery/arte-06.jpg", "Elenco do CAAL em espetáculo musical colorido", "Espetáculos", "Universos no palco", "Teatro, dança e imaginação em uma só experiência.", 1323, 633, "landscape", "center"),
        new("/images/gallery/arte-11.jpg", "Grupo adulto dançando em figurinos verdes", "Espetáculos", "Arte para toda a vida", "Nunca é cedo ou tarde para se expressar.", 720, 885, "portrait", "center"),
        new("/images/gallery/arte-01.jpg", "Grupo de bailarinas em composição contemporânea", "Competições", "Sintonia", "Muitas histórias, um mesmo pulso.", 974, 793, "landscape", "center"),
        new("/images/gallery/arte-07.jpg", "Elenco em celebração durante espetáculo", "Espetáculos", "Aplausos que ficam", "O palco como lugar de encontro e celebração.", 850, 853, "square", "center"),
        new("/images/gallery/arte-14.jpg", "Bailarina de jazz com figurino preto e chapéu", "Aulas", "Personalidade", "Técnica para revelar um jeito único de dançar.", 720, 900, "portrait", "center"),
        new("/images/gallery/trofeus.jpg", "Coleção de troféus do Centro de Artes Almira Lopes", "Conquistas", "Excelência reconhecida", "Premiações que celebram o trabalho de toda a equipe.", 1599, 899, "landscape", "center"),
        new("/images/gallery/medalhas.jpg", "Medalhas conquistadas por artistas do CAAL", "Conquistas", "Mérito em cada detalhe", "Dedicação transformada em resultado.", 884, 1600, "portrait", "center")
    ];

    public static readonly IReadOnlyList<ScheduleItem> Schedule =
    [
        new("Segunda", "17h — 21h"),
        new("Terça", "16h — 21h"),
        new("Quarta", "17h — 21h30"),
        new("Quinta", "17h — 21h"),
        new("Sexta", "17h — 21h"),
        new("Sábado", "8h — 18h"),
        new("Domingo", "Fechado")
    ];
}

public sealed record FeatureItem(string Metric, string Title, string Description, string Index);

public sealed record CourseItem(
    string Slug,
    string Title,
    string Description,
    string Audience,
    string Image,
    string ImagePosition,
    string Monogram);

public sealed record MediaItem(
    string Src,
    string Alt,
    string Category,
    string Title,
    string Caption,
    int Width,
    int Height,
    string Shape,
    string Position);

public sealed record ScheduleItem(string Day, string Hours);

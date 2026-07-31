# Centro de Artes Almira Lopes — Landing Page

Landing page premium construída com **.NET 10 + Blazor WebAssembly standalone**.

## Executar localmente

```powershell
dotnet restore
dotnet run
```

Abra a URL exibida no terminal.

## Deploy na Vercel

O projeto está preparado para ser compilado como site estático e publicado na Vercel. O arquivo `vercel.json` instala o SDK .NET no ambiente de build, publica o aplicativo e configura o fallback de rotas da SPA.

Na configuração do projeto na Vercel:

- selecione **Other** em Framework Preset;
- deixe **Root Directory** vazio ou use `.` (raiz do repositório, onde está `CaalSite.csproj`);
- não use `wwwroot` como Root Directory;
- remova overrides manuais de Install Command, Build Command e Output Directory para que o `vercel.json` seja usado;
- faça um novo deploy sem reutilizar o cache do deploy anterior.

O primeiro build leva mais tempo porque o SDK .NET 10 é baixado no ambiente da Vercel.

Para conferir localmente exatamente o conteúdo estático que será publicado:

```powershell
dotnet publish -c Release -o dist
```

Os arquivos finais ficam em `dist/wwwroot`.

## Conteúdo e imagens

Todas as referências editáveis estão centralizadas em [`Content/SiteContent.cs`](Content/SiteContent.cs):

- cursos e públicos;
- diferenciais;
- horários e links de contato;
- fotos de estrutura e premiações;
- filtros e itens da galeria.

Para adicionar uma imagem à galeria, coloque uma versão otimizada em `wwwroot/images/gallery` e cadastre um novo `MediaItem` na coleção `SiteContent.Gallery`. Não é necessário alterar o HTML/Razor da página.

Os anexos originais permanecem preservados na pasta `imgs`. As cópias usadas pelo site foram convertidas para JPEG otimizado para reduzir o carregamento.

## Estrutura principal

- `Components/Pages/Home.razor` — composição da landing page e interações Blazor;
- `Components/Shared` — cards e títulos reutilizáveis;
- `Content/SiteContent.cs` — catálogo único de conteúdo e mídia;
- `wwwroot/app.css` — identidade visual e breakpoints;
- `wwwroot/js/site.js` — animações progressivas, parallax e contadores.

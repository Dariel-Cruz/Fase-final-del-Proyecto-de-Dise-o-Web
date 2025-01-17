<nav class="navbar navbar-expand-lg sticky-top">
    <div class="container-fluid">
        <a class="navbar-brand" href="#inicio">Mi Sitio</a>
        <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
            <span class="navbar-toggler-icon"></span>
        </button>

        <div class="collapse navbar-collapse" id="navbarNav">
            <ul class="navbar-nav">
                <li class="nav-item">
                    <a class="nav-link" href="#inicio" data-bs-toggle="collapse" data-bs-target="#navbarNav">INICIO</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="#acerca" data-bs-toggle="collapse" data-bs-target="#navbarNav">ACERCA DE NOSOTROS</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="#programas" data-bs-toggle="collapse" data-bs-target="#navbarNav">PROGRAMAS ACADÉMICOS</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="#actividades" data-bs-toggle="collapse" data-bs-target="#navbarNav">ACTIVIDADES</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="#contacto" data-bs-toggle="collapse" data-bs-target="#navbarNav">CONTACTO</a>
                </li>
            </ul>
        </div>
    </div>
</nav>

<!-- Script para desplazamiento suave -->
<script>
    document.addEventListener("DOMContentLoaded", function () {
        const links = document.querySelectorAll('a[href^="#"]');
        
        for (const link of links) {
            link.addEventListener("click", function (event) {
                event.preventDefault();
                const targetID = this.getAttribute("href");
                const targetElement = document.querySelector(targetID);
                
                if (targetElement) {
                    window.scrollTo({
                        top: targetElement.offsetTop,
                        behavior: "smooth"
                    });
                }
            });
        }
    });

    

document.addEventListener("DOMContentLoaded", function () {
    const navbarCollapse = document.getElementById("navbarNav"); // Ajusta el ID al de tu collapse
    const navbarLinks = navbarCollapse.querySelectorAll("a.nav-link");

    navbarLinks.forEach(link => {
        link.addEventListener("click", () => {
            // Si el menú está en modo collapse (visible en pantallas pequeñas)
            if (window.getComputedStyle(navbarCollapse).display === "block") {
                // Cierra el menú
                $('.navbar-collapse').collapse('hide');
            }
        });
    });
});

</script>




<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <title>Escuela de Oficios San Rafael del Sur</title>

    <!-- Enlace a Bootstrap CSS -->
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css">
    <!-- Bootstrap Icons -->
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.11.3/font/bootstrap-icons.min.css">
    <link href="https://fonts.googleapis.com/css2?family=Roboto:wght@400&display=swap" rel="stylesheet">
    <link href="https://fonts.googleapis.com/css2?family=Roboto+Slab:wght@400;600&display=swap" rel="stylesheet">

    <!-- Archivo CSS personalizado -->
    <link rel="stylesheet" href="web.css">
</head>
<body>
   <!-- Contenedor de Logos -->
<div class="container-fluid mb-3 mt-3">
    <div class="row align-items-center">
        <div class="col-sm-3 col-md-3 text-center">
            <img class="img-fluid" src="Logos/inatec-logo-9518FD4AC8-seeklogo.com.png" alt="Logo Inatec Blanco">
        </div>
        <div class="col-sm-6 col-md-6 d-flex justify-content-center">
            <div class="col-sm-3 col-md-3 mb-5 text-center">
                <img class="centered-logo img-fluid" src="Logos/rafael2021.png" alt="Logo Inatec Blanco">
            </div>
            
        </div>
        <div class="col-sm-3 col-md-3 text-center">
            <img src="Logos/gobierno-de-nicaragua-logo-1B0EAA59FF-seeklogo.com.png" class="img-fluid" alt="Logo Gobierno 2023">
        </div>
    </div>
</div>
    <!-- Aquí inicia la Navbar -->
    <nav id="programas" class="navbar navbar-expand-lg sticky-top">
        <div class="container-fluid">
            <div class="row">
            <div class="col-lg-3 col-lg-6 col-lg-12">
                
            </div>
            <a class="navbar-brand" href="#inicio"></a>
            <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarNav"
                aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>

            <div class="collapse navbar-collapse flex-column flex-lg-row" id="navbarNav">
                <ul class="navbar-nav">
                    <li class="nav-item active">
                        <a class="nav-link" href="#inicio">INICIO <span class="sr-only">(actual)</span></a>

                    </li>
                     <li class="nav-item ">
                        <a class="nav-link dropdown-toggle" href="#acerca"> ACERCA DE NOSOTROS</a>
                    </li>
                   
                    <li class="nav-item dropdown">
                        <a class="nav-link dropdown-toggle" href="#programas" id="navbarDropdownAcademicos"
                            role="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                            PROGRAMAS ACADÉMICOS
                        </a>
                        <div class="dropdown-menu" aria-labelledby="navbarDropdownAcademicos">
                            <a class="dropdown-item" href="#tecnologia">CURSOS</a>
                            <a class="dropdown-item" href="#mantenimiento">Mantenimiento y Reparación de Computadoras</a>
                            <a class="dropdown-item" href="#decoracion">Decoración de Eventos</a>
                            <a class="dropdown-item" href="#gastronomia">Gastronomía</a>

                        </div>
                    </li>

                     <li class="nav-item dropdown">
                        <a class="nav-link dropdown-toggle" href="#actividades" id="navbarDropdownAcademicos"
                            role="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                            ACTIVIDADES
                        </a>
                        <div class="dropdown-menu" aria-labelledby="navbarDropdownAcademicos">
                            <a class="dropdown-item" href="#noticias">Noticias</a>
                            <a class="dropdown-item" href="#eventos">Eventos</a>
                            <a class="dropdown-item" href="#videos">Sesión de videos</a>



                            
                        </div>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="#contacto">CONTACTO</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="#matriculate">MATRICÚLATE</a>
                    </li>
                </ul>
                <form class="d-flex ms-auto" role="search">
    <input class="form-control me-2" type="search" placeholder="Buscar" aria-label="Search">
    <button class="btn btn-outline-success" type="submit">Buscar</button>
</form>

            </div>
        </div>
    </nav>


    <!-- Inicia el Hero -->
    <div id="carouselExampleAutoplaying" class="carousel slide" data-ride="carousel">
        <div class="carousel-inner mt-1">
            <div class="carousel-item active">
                <img src="Hero/banner-portal-E.jpg" class="d-block w-100 img-fluid" alt="Descripción de la imagen 1">
            </div>
            <div class="carousel-item">
                <img src="Hero/back_to_school_facebook_cover_17.jpg" class="d-block w-100 img-fluid"
                    alt="Descripción de la imagen 2">
            </div>
            <div class="carousel-item">
                <img src="Hero/back_to_school_facebook_cover_31.jpg" class="d-block w-100 img-fluid"
                    alt="Descripción de la imagen 3">
            </div>
        </div>
        <a class="carousel-control-prev" href="#carouselExampleAutoplaying" role="button" data-slide="prev">
            <span class="carousel-control-prev-icon" aria-hidden="true"></span>
            <span class="sr-only">Anterior</span>
        </a>
        <a class="carousel-control-next" href="#carouselExampleAutoplaying" role="button" data-slide="next">
            <span class="carousel-control-next-icon" aria-hidden="true"></span>
            <span class="sr-only">Siguiente</span>
        </a>
    </div>



    <!-- Sección de Inicio -->
    <div id="inicio" class="inicio container-fluid mt-3">
        <h1 class="titulo-principal text-center">Bienvenidos a la Escuela Técnica de San Rafael del Sur</h1>
    </div>
    <div class="row align-items-center">
        <!-- Contenedor para la imagen y la reseña histórica -->
        <div class="col-lg-6 col-md-6 col-sm-12">
            <img src="Inicio/327713114_5969093676492718_2005376533459337805_n (3).webp" class="img-fluid rounded mb-3"
                alt="Imagen de la Escuela Técnica de San Rafael del Sur">
        </div>

        <div class="col-lg-6 col-md-6 col-sm-12">
            <h3 class="inicio-subtitle text-center">Reseña Histórica</h3>
            <div class="reseña-wrapper">
                <div class="reseña-content">
                    <div class="reseña-text">
                        <p class="inicio-text text-justify">
                            La Escuela Técnica de San Rafael del Sur fue fundada en 1985 con el objetivo de
                            proporcionar una educación técnica accesible y de calidad a los jóvenes de la región. La
                            creación de la institución fue una respuesta a la necesidad de formar a una nueva
                            generación en habilidades técnicas y profesionales, buscando fortalecer la economía
                            local y brindar oportunidades laborales a sus egresados.
                            <br><br>
                            A lo largo de los años, la escuela ha evolucionado para adaptarse a los cambios en el
                            mercado laboral y las necesidades de la comunidad. En sus inicios, la oferta educativa
                            se centraba en áreas fundamentales como carpintería, mecánica y agricultura. Sin
                            embargo, con el tiempo, la institución amplió su enfoque hacia disciplinas más
                            contemporáneas, incluyendo la informática, la electrónica y la administración,
                            integrando tecnologías modernas para preparar a sus estudiantes con las competencias más
                            demandadas.
                            <br><br>
                            La Escuela Técnica de San Rafael del Sur se destaca por sus programas de formación
                            integral, que no solo capacitan a los estudiantes en competencias técnicas, sino que
                            también fomentan valores esenciales como la responsabilidad, el trabajo en equipo y el
                            compromiso con el desarrollo comunitario. A través de convenios con empresas locales y
                            organismos gubernamentales, la institución facilita la inserción laboral de sus
                            egresados, quienes son reconocidos por su preparación y ética profesional.
                            <br><br>
                            Hoy en día, la escuela sigue siendo un pilar fundamental en la educación técnica de la
                            región, manteniendo su compromiso de ofrecer educación gratuita y de calidad a cientos
                            de estudiantes cada año. La Escuela Técnica de San Rafael del Sur continúa creciendo y
                            adaptándose a los desafíos del siglo XXI, fortaleciendo su misión de formar
                            profesionales capaces de contribuir al desarrollo sostenible de Nicaragua.
                        </p>
                    </div>
                </div>
            </div>
        </div>
    </div>
    </div>

    <!-- Sesión Acerca de nosotros -->

    <div id="acerca" class="container  mb-4 mt-4">
        <h2 class="sesion-title text-left">ACERCA DE NOSOTROS</h2>
        <div class="row justify-content-center">
            <!-- Primera tarjeta con imagen a la izquierda -->
            <div class="col-lg-6 col-md-6 col-sm-12 mb-4">
                <div class="card">
                    <img src="Acerca de nosotros/riug9o0p.webp" class="card-img-top img-fluid" alt="Imagen Izquierda">
                    <div class="card-body text-center">
                        <h5 class="card-title">MISIÓN</h5>
                        <p class="card-text text-justify">"Formar profesionales altamente capacitados en diversas áreas
                            tecnológicas, promoviendo una educación práctica y accesible que impulse el desarrollo de
                            habilidades técnicas y éticas. Nuestra misión es preparar a nuestros estudiantes para
                            enfrentar los desafíos de un entorno laboral en constante cambio, brindándoles las
                            herramientas y el conocimiento necesarios para contribuir al progreso y la innovación de su
                            comunidad y del país."</p>
                    </div>
                </div>
            </div>

            <!-- Segunda tarjeta con imagen a la derecha -->
            <div class="col-lg-6 col-md-6 col-sm-12 mb-4">
                <div class="card">
                    <img src="Acerca de nosotros/2xlmkxma.webp" class="card-img-top img-fluid" alt="Imagen Derecha">
                    <div class="card-body text-center">
                        <h5 class="card-title">VISIÓN</h5>
                        <p class="card-text text-justify">"Ser un referente nacional en la educación tecnológica y
                            formación de oficios, destacándonos por nuestra calidad educativa, innovación y compromiso
                            con el desarrollo profesional de nuestros estudiantes. Aspiramos a empoderar a nuestros
                            graduados con competencias tecnológicas avanzadas que les permitan destacarse en el ámbito
                            laboral, contribuyendo así al crecimiento y a la sostenibilidad de la economía local y
                            nacional."</p>
                    </div>
                </div>
            </div>
        </div>
    </div>
<!-- Curso de Mantenimiento y Reparación de Computadoras-->
<h3 class="card-title">MANTENIMIENTO Y REPARACIÓN DE PC</h3>

<div id="mantenimiento" class="row container-fluid w-100 my-4">
    <div class="col-lg-3 col-md-6 col-sm-12">
        <div class="card">
            <img src="Ofertas Académicas/Cur/2/1.webp" class="card-img-top img-fluid" alt="Imagen de curso de mantenimiento" aria-label="Imagen de curso de mantenimiento">
            <div class="card-body">
                <h4 class="card-subtitle mb-2 text-muted">Mantenimiento</h4>
                <p class="card-text text-justify">
                    Jóvenes estudiantes del curso de diseño y presentaciones de la escuela municipal de oficios
                    exponiendo sus trabajos en conmemoración a nuestro mes patrio, gracias al gobierno de
                    Reconciliación y Unidad Nacional por brindar educación gratuita y de calidad. ❤🖤🇳🇮✌
                    #2021OrgulloPatrio #SanRafaelDelSur #2021PatriaBenditaYLibre
                </p>
            </div>
        </div>
    </div>
    <div class="col-lg-3 col-md-6 col-sm-12">
        <div class="card">
            <img src="Ofertas Académicas/Cur/2/2.webp" class="card-img-top img-fluid" alt="Curso de manualidades" aria-label="Curso de manualidades">
            <div class="card-body">
                <h4 class="card-subtitle mb-2 text-muted">Manualidades</h4>
                <p class="card-text text-justify">
                    En conmemoración a nuestro mes patrio, compañeras del curso de decoración para eventos
                    en El Chilamatillo realizaron hermosas manualidades, demostrando su formación técnica
                    recibida. ✌🖤❤🇳🇮 #2021PatriaBenditaYLibre #2021DignosYLibres #2021OrgulloPatrio
                </p>
            </div>
        </div>
    </div>
    <div class="col-lg-3 col-md-6 col-sm-12">
        <div class="card">
            <img src="Ofertas Académicas/Cur/2/3.webp" class="card-img-top img-fluid" alt="Curso de sistemas operativos y ofimática" aria-label="Curso de sistemas operativos y ofimática">
            <div class="card-body">
                <h4 class="card-subtitle mb-2 text-muted">Sistemas Operativos y Ofimática</h4>
                <p class="card-text text-justify">
                    #26agosto // Clases del curso de Sistemas Operativos y Ofimática en el turno matutino.
                    🤓👨🏻‍🏫🎓🖥🖱🌐📶 #ManaguaSandinista #SanRafaelDelSur #2021OrgulloPatrio
                    #SanRafaelDelSur #2021PatriaBenditaYLibre
                </p>
            </div>
        </div>
    </div>
    <div class="col-lg-3 col-md-6 col-sm-12">
        <div class="card">
            <img src="Ofertas Académicas/Cur/2/4.webp" class="card-img-top img-fluid" alt="Curso de sistemas operativos y ofimática" aria-label="Curso de sistemas operativos y ofimática">
            <div class="card-body">
                <h4 class="card-subtitle mb-2 text-muted">Sistemas Operativos y Ofimática</h4>
                <p class="card-text text-justify">
                    #26agosto // Clases de Sistemas Operativos y Ofimática en el turno matutino.
                    🤓👨🏻‍🏫🎓🖥🖱🌐📶 #ManaguaSandinista #SanRafaelDelSur #2021PatriaBenditaYLibre
                    #2021DignosYLibres #2021OrgulloPatrio
                </p>
            </div>
        </div>  
    </div>  
</div>
   <!-- Curso de Gastronomía -->
            <h3 class="card-title text-center">GASTRONOMÍA</h3>
            <div id="gastronomia" class="container-fluid">
                <div class="row">
                    <div class="col-lg-4 col-md-4 col-sm-12">
                        <div class="card">
                            <img src="Ofertas Académicas/Gastronomía/3/1.webp" class="card-img-top img-fluid"
                                alt="Curso de Manualidades">
                            <div class="card-body">
                                <h4 class="card-subtitle mb-2 text-muted">Manualidades</h4>
                                <p class="card-text text-justify">
                                    Protagonistas del curso de decoración para eventos de la comunidad El Chilamatillo
                                    demostrando la calidad de los cursos que se imparten y demostrando sus habilidades
                                    adquiridas, gracias al apoyo de nuestro gobierno.
                                    <br>
                                    #InsurreccionDeLaEsperanza #ManaguaSandinista #SanRafaelDelSur
                                </p>
                            </div>
                        </div>
                    </div>

                    <!-- Card con Imagen 2 -->
                    <div class="col-lg-4 col-md-4 col-sm-12">
                        <div class="card">
                            <img src="Ofertas Académicas/Gastronomía/3/2.webp" class="card-img-top img-fluid"
                                alt="Curso de Manualidades">
                            <div class="card-body">
                                <h4 class="card-subtitle mb-2 text-muted">Manualidades</h4>
                                <p class="card-text text-justify">
                                    Protagonistas del curso de decoración para eventos de la comunidad El Chilamatillo
                                    demostrando la calidad de los cursos que se imparten y demostrando sus habilidades
                                    adquiridas, gracias al apoyo de nuestro gobierno.
                                    <br>
                                    #InsurreccionDeLaEsperanza #ManaguaSandinista #SanRafaelDelSur
                                </p>
                            </div>
                        </div>
                    </div>

                    <!-- Card con Imagen 3 -->
                    <div class="col-lg-4 col-md-4 col-sm-12">
                        <div class="card">
                            <img src="Ofertas Académicas/Gastronomía/3/3.webp" class="card-img-top img-fluid"
                                alt="Curso de Manualidades">
                            <div class="card-body">
                                <h4 class="card-subtitle mb-2 text-muted">Manualidades</h4>
                                <p class="card-text text-justify">
                                    Protagonistas del curso de decoración para eventos de la comunidad El Chilamatillo
                                    demostrando la calidad de los cursos que se imparten y demostrando sus habilidades
                                    adquiridas, gracias al apoyo de nuestro gobierno.
                                    <br>
                                    #InsurreccionDeLaEsperanza #ManaguaSandinista #SanRafaelDelSur
                                </p>
                            </div>
                        </div>
                    </div>

                </div> <!-- Cierre de la fila -->
            </div> <!-- Cierre del contenedor -->

            <!-- Curso de Decoración de Eventos -->
            <h3 class="card-title text-center">DECORACIÓN DE EVENTOS </h3>

            <div id="decoracion" class="container-fluid">
                <div class="row">
                    <div class="col-lg-6 col-md-6 col-sm-12">
                        <div class="card">
                            <img src="Ofertas Académicas/Decoración/decoracion.2.webp" class="card-img-top img-fluid"
                                alt="Curso 1">
                            <div class="card-body">
                                <h4 class="card-subtitle mb-2  text-muted">Manualidades</h4>
                                <p class="card-text text-justify">Preciosas decoraciones de montaje para evento de las
                                    compañeras protagonistas del curso de decoración para eventos comunidad el
                                    chilamatillo demostrando la calidad de nuestros programas sociales fomentados por
                                    nuestro gobierno del frente sandinista ❤🖤
                                    #EnVictoriosaEsperanza
                                    #ManaguaSandinista</p>
                            </div>
                        </div>
                    </div>

                    <div class="col-lg-6 col-md-6 col-sm-12">
                        <div class="card">
                            <img src="Ofertas Académicas/Decoración/Decoración.webp" class="card-img-top img-fluid"
                                alt="Curso 1">
                            <div class="card-body">
                                <h4 class="card-subtitle mb-2  text-muted">Manualidades</h4>
                                <p class="card-text text-justify">En conmemoración a nuestro mes patrio las compañeras
                                    protagonistas del curso de decoración para eventos comunidad El Chilamatillo
                                    realizaron
                                    estas lindas manualidades demostrando la educación técnica que han recibido de parte
                                    de
                                    nuestro gobierno sandinista ✌🖤❤🇳🇮
                                    #2021PatriaBenditaYLibre
                                    #2021DignosYLibres
                                    #2021OrgulloPatrio</p>
                            </div>
                        </div>
                    </div>
                    
                     <!-- Sesión de Actividades -->
            <h3 class="card-title text-center">NOTICIAS</h3>
            <div id="noticias" class="container-fluid">
                <div class="row">
                    <div class="col-lg-4 col-md-4 col-sm-12">
                        <div class="card">
                            <img src="Ofertas Académicas/Gastronomía/3/1.webp" class="card-img-top img-fluid"
                                alt="Curso de Manualidades">
                            <div class="card-body">
                                <h4 class="card-subtitle mb-2 text-muted">Manualidades</h4>
                                <p class="card-text text-justify">
                                    Protagonistas del curso de decoración para eventos de la comunidad El Chilamatillo
                                    demostrando la calidad de los cursos que se imparten y demostrando sus habilidades
                                    adquiridas, gracias al apoyo de nuestro gobierno.
                                    <br>
                                    #InsurreccionDeLaEsperanza #ManaguaSandinista #SanRafaelDelSur
                                </p>
                            </div>
                        </div>
                    </div>

                    <!-- Card con Imagen 2 -->
                    <div class="col-lg-4 col-md-4 col-sm-12">
                        <div class="card">
                            <img src="Ofertas Académicas/Gastronomía/3/2.webp" class="card-img-top img-fluid"
                                alt="Curso de Manualidades">
                            <div class="card-body">
                                <h4 class="card-subtitle mb-2 text-muted">Manualidades</h4>
                                <p class="card-text text-justify">
                                    Protagonistas del curso de decoración para eventos de la comunidad El Chilamatillo
                                    demostrando la calidad de los cursos que se imparten y demostrando sus habilidades
                                    adquiridas, gracias al apoyo de nuestro gobierno.
                                    <br>
                                    #InsurreccionDeLaEsperanza #ManaguaSandinista #SanRafaelDelSur
                                </p>
                            </div>
                        </div>
                    </div>

                    <!-- Card con Imagen 3 -->
                    <div class="col-lg-4 col-md-4 col-sm-12">
                        <div class="card">
                            <img src="Ofertas Académicas/Gastronomía/3/3.webp" class="card-img-top img-fluid"
                                alt="Curso de Manualidades">
                            <div class="card-body">
                                <h4 class="card-subtitle mb-2 text-muted">Manualidades</h4>
                                <p class="card-text text-justify">
                                    Protagonistas del curso de decoración para eventos de la comunidad El Chilamatillo
                                    demostrando la calidad de los cursos que se imparten y demostrando sus habilidades
                                    adquiridas, gracias al apoyo de nuestro gobierno.
                                    <br>
                                    #InsurreccionDeLaEsperanza #ManaguaSandinista #SanRafaelDelSur
                                </p>
                            </div>
                        </div>
                    </div>

                </div> <!-- Cierre de la fila -->
            </div> <!-- Cierre del contenedor -->

             <!-- Sesión de Eventos-->

             <h3 class="card-title text-center">EVENTOS</h3>
             <div id="eventos" class="container-fluid">
                 <div class="row">
                     <div class="col-lg-4 col-md-4 col-sm-12">
                         <div class="card">
                             <img src="Ofertas Académicas/Gastronomía/3/1.webp" class="card-img-top img-fluid"
                                 alt="Curso de Manualidades">
                             <div class="card-body">
                                 <h4 class="card-subtitle mb-2 text-muted">Manualidades</h4>
                                 <p class="card-text text-justify">
                                     Protagonistas del curso de decoración para eventos de la comunidad El Chilamatillo
                                     demostrando la calidad de los cursos que se imparten y demostrando sus habilidades
                                     adquiridas, gracias al apoyo de nuestro gobierno.
                                     <br>
                                     #InsurreccionDeLaEsperanza #ManaguaSandinista #SanRafaelDelSur
                                 </p>
                             </div>
                         </div>
                     </div>
 
                     <!-- Card con Imagen 2 -->
                     <div class="col-lg-4 col-md-4 col-sm-12">
                         <div class="card">
                             <img src="Ofertas Académicas/Gastronomía/3/2.webp" class="card-img-top img-fluid"
                                 alt="Curso de Manualidades">
                             <div class="card-body">
                                 <h4 class="card-subtitle mb-2 text-muted">Manualidades</h4>
                                 <p class="card-text text-justify">
                                     Protagonistas del curso de decoración para eventos de la comunidad El Chilamatillo
                                     demostrando la calidad de los cursos que se imparten y demostrando sus habilidades
                                     adquiridas, gracias al apoyo de nuestro gobierno.
                                     <br>
                                     #InsurreccionDeLaEsperanza #ManaguaSandinista #SanRafaelDelSur
                                 </p>
                             </div>
                         </div>
                     </div>
 
                     <!-- Card con Imagen 3 -->
                     <div class="col-lg-4 col-md-4 col-sm-12">
                         <div class="card">
                             <img src="Ofertas Académicas/Gastronomía/3/3.webp" class="card-img-top img-fluid"
                                 alt="Curso de Manualidades">
                             <div class="card-body">
                                 <h4 class="card-subtitle mb-2 text-muted">Manualidades</h4>
                                 <p class="card-text text-justify">
                                     Protagonistas del curso de decoración para eventos de la comunidad El Chilamatillo
                                     demostrando la calidad de los cursos que se imparten y demostrando sus habilidades
                                     adquiridas, gracias al apoyo de nuestro gobierno.
                                     <br>
                                     #InsurreccionDeLaEsperanza #ManaguaSandinista #SanRafaelDelSur
                                 </p>
                             </div>
                         </div>
                     </div>
 
                 </div> <!-- Cierre de la fila -->
             </div> <!-- Cierre del contenedor -->
 
            
             <h3 class="card-title text-center">SESIÓN DE VIDEOS</h3>

                    <di id="videos" class="container-fluid">
                        <div class="row">
                            <!-- Primer video y descripción -->
                            <div class="col-lg-3 col-md-12 mb-4">
                                <div class="embed-responsive embed-responsive-16by9">
                                    <video src="Ofertas Académicas/Gastronomía/3/669274380924641.mp4"
                                        class="card-img-top img-fluid" autoplay loop muted poster="Ofertas Académicas/Gastronomía/retro-poster.jpg">
                                    </video>
                                </div>
                                <div class="card-body">
                                    <h5 class="card-title text-center">Curso de Gastronomía</h5>
                                    <h6 class="card-subtitle mb-2 text-muted">Exploración y práctica culinaria</h6>
                                    <p class="card-text text-justify">
                                        Este curso introduce a los estudiantes en técnicas de cocina clásica, permitiéndoles revivir y experimentar la gastronomía de décadas pasadas.
                                    </p>
                                </div>
                            </div>     
                                    <!-- Segundo video y descripción -->
                                    <div class="col-lg-6 col-md-12 mb-4">
                                        <div class="embed-responsive embed-responsive-16by9">
                                            <video src="Ofertas Académicas/Gastronomía/3/669274380924641.mp4"
                                                class="card-img-top img-fluid" autoplay loop muted poster="Ofertas Académicas/Gastronomía/retro-poster.jpg">
                                            </video>
                                        </div>
                                        <div class="card-body">
                                            <h5 class="card-title ">Curso de Gastronomía</h5>
                                            <h6 class="card-subtitle mb-2 text-muted">Exploración y práctica culinaria</h6>
                                            <p class="card-text text-justify">
                                                Este curso introduce a los estudiantes en técnicas de cocina clásica, permitiéndoles revivir y experimentar la gastronomía de décadas pasadas.
                                            </p>
                                        </div>
                                    </div>
                            
                                    <!-- Tercer video y descripción -->
                                    <div class="col-lg-3 col-md-12 mb-4">
                                        <div class="embed-responsive embed-responsive-16by9">
                                            <video src="Ofertas Académicas/Gastronomía/3/669274380924641.mp4"
                                                class="card-img-top img-fluid" autoplay loop muted poster="Ofertas Académicas/Gastronomía/retro-poster.jpg">
                                            </video>
                                        </div>
                                        <div class="card-body">
                                            <h5 class="card-title">Curso de Gastronomía</h5>
                                            <h6 class="card-subtitle mb-2 text-muted">Exploración y práctica culinaria</h6>
                                            <p class="card-text text-justify">
                                                Este curso introduce a los estudiantes en técnicas de cocina clásica, permitiéndoles revivir y experimentar la gastronomía de décadas pasadas.
                                            </p>
                                        </div>
                                    </div>
                                </div>
                            </div>

                            <!-- Carousel para la sección de matrícula-->
                            <div id="matriculate" class="carousel slide" data-ride="carousel">
                                <div class="carousel-inner">
                                    <div class="carousel-item active">
                                        <img src="Hero/banner-portal-E.jpg" class="d-block w-100 img-fluid"
                                            alt="Descripción de la imagen 1">
                                    </div>
                                    <div class="carousel-item">
                                        <img src="Hero/back_to_school_facebook_cover_17.jpg"
                                            class="d-block w-100 img-fluid" alt="Descripción de la imagen 2">
                                    </div>
                                    <div class="carousel-item">
                                        <img src="Hero/back_to_school_facebook_cover_31.jpg"
                                            class="d-block w-100 img-fluid" alt="Descripción de la imagen 3">
                                    </div>
                                </div>
                                <a class="carousel-control-prev" href="#carouselExampleAutoplaying" role="button"
                                    data-slide="prev">
                                    <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                                    <span class="sr-only">Anterior</span>
                                </a>
                                <a class="carousel-control-next" href="#carouselExampleAutoplaying" role="button"
                                    data-slide="next">
                                    <span class="carousel-control-next-icon" aria-hidden="true"></span>
                                    <span class="sr-only">Siguiente</span>
                                </a>
                            </div>

                            <!--Aquí comienza el formulario de contacto-->
                            <div id="contacto" class="container-fluid mt-5 mb-5">
                                <h2>Formulario de Registro</h2>
                                <form>
                                    <!-- Fila para Nombre y Apellido -->
                                    <div class="row">
                                        <div class="col-md-6 mb-3">
                                            <label class="form-label" for="input_name">Nombre:</label>
                                            <input type="text" id="input_name" class="form-control" required>
                                        </div>
                                        <div class="col-md-6 mb-3">
                                            <label class="form-label" for="input_lastname">Apellido:</label>
                                            <input type="text" id="input_lastname" class="form-control" required>
                                        </div>
                                    </div>

                                    <!-- Campo de Email -->
                                    <label class="form-label" for="input_email">Email:</label>
                                    <div class="input-group mb-3">
                                        <span class="input-group-text">@</span>
                                        <input type="email" id="input_email" class="form-control" required>
                                    </div>

                                    <!-- Fila para Teléfono, País, Ciudad y Fecha de Nacimiento -->
                                    <div class="row">
                                        <div class="col-md-3 mb-3">
                                            <label class="form-label" for="telefono">Teléfono:</label>
                                            <input type="tel" id="telefono" class="form-control" required>
                                        </div>
                                        <div class="col-md-3 mb-3">
                                            <label class="form-label" for="pais">País:</label>
                                            <input type="text" id="pais" class="form-control" list="paises" required>
                                            <datalist id="paises">
                                                <option value="España">
                                                <option value="Argentina">
                                                <option value="México">
                                                <option value="Colombia">
                                                <option value="Chile">
                                            </datalist>
                                        </div>
                                        <div class="col-md-3 mb-3">
                                            <label class="form-label" for="ciudad">Ciudad:</label>
                                            <select id="ciudad" class="form-select mb-3" required>
                                                <option value="">Seleccione una ciudad</option>
                                                <option value="madrid">Madrid</option>
                                                <option value="bogota">Bogotá</option>
                                                <option value="mexico">Mexico D.C.</option>
                                                <option value="buenos_aires">Buenos Aires</option>
                                                <option value="santiago">Santiago de Chile</option>
                                            </select>
                                        </div>
                                        <div class="col-md-3 mb-3">
                                            <label class="form-label" for="fecha">Fecha de nacimiento:</label>
                                            <input type="date" id="fecha" class="form-control" required>
                                        </div>
                                    </div>

                                    <!-- Fila para Color, Nivel de Conocimientos y Foto de Perfil -->
                                    <div class="row">
                                        <div class="col-md-4 mb-3">
                                            <label class="form-label" for="color">Color de identificación:</label>
                                            <input type="color" id="color" class="form-control form-control-color"
                                                required>
                                        </div>
                                        <div class="col-md-4 mb-3">
                                            <label class="form-label" for="conocimientos">Nivel de
                                                conocimientos:</label>
                                            <input type="range" id="conocimientos" class="form-range" min="1" max="10"
                                                required>
                                        </div>
                                        <div class="col-md-4 mb-3">
                                            <label class="form-label" for="foto">Foto de perfil:</label>
                                            <input type="file" id="foto" class="form-control">
                                        </div>
                                    </div>

                                    <!-- Fila para Intereses (checkboxes) -->
                                    <div class="row text-center">
                                        <div class="col-md-4 offset-md-4 mb-3">
                                            <label for="intereses">Intereses:</label><br>
                                            <div class="form-check form-check-inline">
                                                <input type="checkbox" id="tecnologia" value="tecnologia"
                                                    class="form-check-input">
                                                <label for="tecnologia" class="form-check-label">Tecnología</label>
                                            </div>
                                            <div class="form-check form-check-inline">
                                                <input type="checkbox" id="negocios" value="negocios"
                                                    class="form-check-input">
                                                <label for="negocios" class="form-check-label">Negocios</label>
                                            </div>
                                            <div class="form-check form-check-inline">
                                                <input type="checkbox" id="arte" value="arte" class="form-check-input">
                                                <label for="arte" class="form-check-label">Arte</label>
                                            </div>
                                        </div>
                                    </div>

                                    <!-- Área de texto para comentarios -->
                                    <label class="form-label" for="comentarios">Comentarios adicionales:</label>
                                    <textarea id="comentarios" class="form-control mb-3" rows="4" cols="30"></textarea>

                                    <!-- Botones de envío y cancelación -->
                                    <div class="text-center">
                                        <button type="submit" class="btn btn-primary btn-lg">Enviar</button>
                                        <button type="reset" class="btn btn-danger btn-lg">Cancelar</button>
                                    </div>
                                </form>
                            </div>

                            <footer>
                                <div class="container-fluid ultimod">
                                  <div class="row">
                                    <div class="col-xs-12 col-sm-3 col-md-2" style="padding-top: 5px">
                                      <img class="img-responsive" src="Logos/inatec-logo-9518FD4AC8-seeklogo.com.png" alt="Logo Inatec Blanco"><br>
                                    </div>
                                    <div class="col-xs-12 col-sm-6 col-md-8">
                                      <div class="content text-center">
                                        Capacitación y Educación Técnica Gratuita y de Calidad. <br>
                                        Dirección: Centro Cívico Zumen, frente al Hospital Bertha Calderón, Managua. <br>
                                        Teléfonos: Planta Central 2253-8830, Atención al Protagonista 2253-8888
                                      </div>
                                      <div class="row">
                                        <div class="col-xs-4 col-sm-4 col-md-4">
                                        
                                        </div>
                                      </div>
                                     <!-- Contenedor de los iconos de redes sociales -->
<div class="social">
    <a href="https://www.facebook.com/TecNacional" target="_blank" class="blanco">
        <i class="bi bi-facebook"></i> <!-- Icono de Facebook -->
    </a>
    <a href="https://twitter.com/TecNacional" target="_blank" class="blanco">
        <i class="bi bi-twitter"></i> <!-- Icono de Twitter -->
    </a>
    <a href="https://www.instagram.com/tecnacional/?hl=es" target="_blank" class="blanco">
        <i class="bi bi-instagram"></i> <!-- Icono de Instagram -->
    </a>
    <a href="https://www.youtube.com/user/TecnologicoNacional" target="_blank" class="blanco">
        <i class="bi bi-youtube"></i> <!-- Icono de YouTube -->
    </a>
</div>
                                    </div>
                                    <div class="col-xs-12 col-sm-3 col-md-2">
                                      <img src="Logos/gobierno-de-nicaragua-logo-1B0EAA59FF-seeklogo.com.png" class="img-responsive pull-right" alt="logo gobierno 2023">
                                    </div>
                                  </div>
                                  <div class="autoria text-center azul">Todos los derechos reservados Tecnológico Nacional</div>
                                </div>
                              </footer>
                              
           
                            <!-- Scripts de jQuery y Bootstrap -->
<script src="https://code.jquery.com/jquery-3.5.1.slim.min.js"></script>
<script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.5.4/dist/umd/popper.min.js"></script>
<script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>

<!-- Script para desplazamiento suave -->
<script>
    document.addEventListener("DOMContentLoaded", function () {
        const links = document.querySelectorAll('a[href^="#"]');
        
        for (const link of links) {
            link.addEventListener("click", function (event) {
                event.preventDefault();
                const targetID = this.getAttribute("href");
                const targetElement = document.querySelector(targetID);
                
                if (targetElement) {
                    window.scrollTo({
                        top: targetElement.offsetTop,
                        behavior: "smooth"
                    });
                }
            });
        }
    });
</script>
<!-- Script JavaScript para controlar la apertura y cierre de submenús -->
<script>
    document.addEventListener('DOMContentLoaded', function () {
        // Mantiene el submenú abierto al hacer clic en el menú principal de "ACTIVIDADES"
        const actividadesMenu = document.querySelector('#navbarDropdownActividades');
        const navbarNav = document.querySelector('.navbar-collapse');

        // Agregar evento para evitar que se cierre automáticamente el submenú de "ACTIVIDADES"
        actividadesMenu.addEventListener('click', function (e) {
            e.stopPropagation(); // Evita el cierre al hacer clic
            this.parentElement.querySelector('.dropdown-menu').classList.toggle('show');
        });

        // Cierra el submenú y el menú principal al hacer clic en un elemento del submenú
        document.querySelectorAll('.dropdown-menu .dropdown-item').forEach(function (dropdownItem) {
            dropdownItem.addEventListener('click', function () {
                // Cierra el submenú
                document.querySelectorAll('.dropdown-menu.show').forEach(function (menu) {
                    menu.classList.remove('show');
                });

                // Cierra el menú principal
                if (navbarNav.classList.contains('show')) {
                    $('.navbar-collapse').collapse('hide');
                }
            });
        });
    });
</script>
</body>
</html>

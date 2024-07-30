<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Inicio de Sesión</title>
    <!-- Bootstrap CSS -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet">
    <link rel="stylesheet" href="styles.css">
</head>
<body>
    <div class="login-container">
        <img src="https://via.placeholder.com/150" alt="Logo" class="logo">
        <form id="login-form">
            <div class="mb-3">
                <label for="username" class="form-label">Usuario</label>
                <input type="text" class="form-control" id="username" required>
            </div>
            <div class="mb-3">
                <label for="password" class="form-label">Contraseña</label>
                <input type="password" class="form-control" id="password" required>
            </div>
            <button type="submit" class="btn btn-danger w-100">Iniciar Sesión</button>
        </form>
        <div id="error-message" class="text-center">
            Usuario o contraseña incorrectos. Por favor, intente nuevamente.
        </div>
    </div>

    <!-- Bootstrap Bundle with Popper -->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/js/bootstrap.bundle.min.js"></script>
    <!-- jQuery -->
    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
    <script src="script.js"></script>
</body>
</html>
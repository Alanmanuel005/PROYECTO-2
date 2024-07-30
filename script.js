// Puedes agregar funcionalidades con JavaScript aquí, por ejemplo:
// - Efectos de hover en las imágenes
// - Un carrusel para mostrar más autos
// - Un formulario de contacto

// Ejemplo de un efecto de hover:
const cars = document.querySelectorAll('.car');
cars.forEach(car => {
    car.addEventListener('mouseover', () => {
        car.style.boxShadow = '0px 5px 10px rgba(0, 0, 0, 0.2)';
    });
    car.addEventListener('mouseout', () => {
        car.style.boxShadow = 'none';
    });
});
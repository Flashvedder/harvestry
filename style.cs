// Product dataset configuration with your exact GitHub Pages URLs
const productsData = {
    'sofa': {
        title: "Arlington Power Reclining Sofa",
        model: "https://flashvedder.github.io/Sofa/model.glb"
    },
    'sofa02': {
        title: "Nordic Sectional 02",
        model: "https://flashvedder.github.io/sofa02/model.glb"
    },
    'stool': {
        title: "Kensington Upholstered Bar Stool",
        model: "https://flashvedder.github.io/Stool/model.glb"
    }
};

// Function to open the AR modal and load the selected furniture model
function openARModal(productKey) {
    const modal = document.getElementById('arModal');
    const title = document.getElementById('modalTitle');
    const viewer = document.getElementById('modalModelViewer');

    const product = productsData[productKey] || productsData['sofa'];

    title.innerText = product.title;
    viewer.setAttribute('src', product.model);

    modal.classList.remove('hidden');
    modal.classList.add('flex');
}

// Function to close the AR modal
function closeARModal() {
    const modal = document.getElementById('arModal');
    modal.classList.remove('flex');
    modal.classList.add('hidden');
}

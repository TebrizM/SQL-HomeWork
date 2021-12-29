// Brand, Model section

function Model(id, name, brandId) {
    this.Id = id;
    this.Name = name;
    this.BrandId = brandId;
}
let model1 = new Model(1, "A3", 1);
let model2 = new Model(2, "A4", 1);
let model3 = new Model(3, "A5", 1);
let model4 = new Model(4, "A6", 1);
let model5 = new Model(5, "A7", 1);
let model6 = new Model(6, "A8", 1);
let model7 = new Model(7, "X5", 2);
let model8 = new Model(8, "X6", 2);
let model9 = new Model(9, "M3", 2);
let model10 = new Model(10, "M4", 2);
let model11 = new Model(11, "M5", 2);
let model12 = new Model(12, "M6", 2);
let model13 = new Model(13, "E-series", 3);
let model14 = new Model(14, "S-series", 3);
let model15 = new Model(14, "C-series", 3);

let models = [];
models.push(model1);
models.push(model2);
models.push(model3);
models.push(model4);
models.push(model5);
models.push(model6);
models.push(model7);
models.push(model8);
models.push(model9);
models.push(model10);
models.push(model11);
models.push(model12);
models.push(model13);
models.push(model14);
models.push(model15);

let brand = document.forms.carForm.elements.Brand;


brand.addEventListener("change", function(e) {
    e.preventDefault();
    let modelChild = document.querySelectorAll("select[name='Model'] option");
    for (let i = 1; i < modelChild.length; i++) {
        modelChild[i].remove();
    }
    for (let i = 0; i < models.length; i++) {
        if (models[i].BrandId == parseInt(this.value)) {
            let option = document.createElement("option");
            option.setAttribute("value", models[i].Id)
            option.innerText = models[i].Name;
            document.forms.carForm.elements.Model.appendChild(option);
        }
    }
})

// Upload Photo Section
let allowDrop = (event) => {
    event.preventDefault();
}
let dropElement = (event) => {
    event.preventDefault();
    let files = [...event.dataTransfer.files]

    for (let i = 0; i < files.length; i++) {
        let reader = new FileReader();
        reader.readAsDataURL(files[i])
        reader.onloadend = () => {
            let img = document.createElement("img")
            img.src = reader.result;
            event.target.append(img);
        };


    }
}

let add = document.querySelector(".Add");
let dropContainer = document.querySelector(".dropContainer");
add.addEventListener('click', function(e) {
    e.preventDefault();
    let inputFile = document.forms.fileForm.inputFile.files;
    let rawfile = [...inputFile];


    rawfile.forEach(file => {
        let reader = new FileReader();
        reader.readAsDataURL(file)
        reader.onloadend = () => {
            let img = document.createElement("img")
            img.src = reader.result;
            dropContainer.append(img);
        };

    })

})
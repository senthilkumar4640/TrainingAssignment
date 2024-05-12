interface ImageDetails{
    url : string;
    caption : string;
}

const images : ImageDetails[] = [
    {
        url:"Images\\DairyMilk.jpg", caption:"Dairy Milk"
    },
    {
        url:"Images\\Mysoresandal.jpg", caption:"Mysore Sandal"
    },
    {
        url:"Images\\Pen.jpg", caption:"Pen"
    },
    {
        url:"Images\\salt.jpg", caption:"Salt"
    },
    {
        url:"Images\\surf.jpg", caption:"Surf"
    }
]

let currentIndex = 0;
 function ShowImage(index : number)
 {
    const imageContainer = document.getElementById('image-container')!;
    const image = document.createElement("img");
    const caption = document.createElement("div");

    image.src = images[index].url;
    caption.textContent = images[index].caption;

    imageContainer.innerHTML = "";
    imageContainer.appendChild(image);
    imageContainer.appendChild(caption);
 }

 function nextImage(){
    currentIndex = (currentIndex+1)%images.length;
    ShowImage(currentIndex);
 }

 function previousImage()
 {
    currentIndex = (currentIndex-1 + images.length) % images.length;
    ShowImage(currentIndex);
 }

 ShowImage(currentIndex);
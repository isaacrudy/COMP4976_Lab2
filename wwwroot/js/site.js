// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

 // Get the current year using JavaScript
 var currentYear = new Date().getFullYear();
    
 // Set the max attribute of the input element to one year from now
 document.getElementById('year').setAttribute('max', currentYear + 1);
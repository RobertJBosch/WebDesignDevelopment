function getTestInstructors() {
    var instructorData = '{"instructors": [{"firstname":"Bill Nye", "middleinitial":"T", "lastname":"Science Guy"},' +
    '{"firstname":"Steve", "middleinitial":"R", "lastname":"Irwin"},' +
    '{"firstname":"Nathan", "middleinitial":"C", "lastname":"Smurthwaite"}]}';
    return JSON.parse(instructorData);
}

function initializeTable() {
    var data = getTestInstructors();
    displayData(data.instructors);
}

function displayData(instructorData) {
    var tableData = "";
    tableData += '<tr><th class="border">First Name</th><th class="border">Middle Initial</th><th class="border">Last Name</th></tr>';
    for (i = 0; i < instructorData.length; i++) {
        var fname = instructorData[i].firstname;
        var middlei = instructorData[i].middleinitial;
        var lname = instructorData[i].lastname;
        tableData += '<tr><td class="border">' + fname + '</td><td class="border">' + middlei + '</td><td class="border">' + lname + '</td></tr>';
    }  
    document.getElementById("instructorTable").innerHTML = tableData;
}
function getTestStudents() {
    var studentData = '{"students": [{"studentid":123456, "emailaddress":"thisisanemailaddress@email.com"},' +
     '{"studentid":789123, "emailaddress": "thisisanotheremail@gmail.com"},' +
     '{"studentid":456789, "emailaddress": "yetanotherone@hemail.com"}]}';
    return JSON.parse(studentData);
}

function initializeTable() {
    var data = getTestStudents();
    displayData(data.students);
}

function displayData(studentData) {
    var tableData = "";
    tableData += '<tr><th class="border">Student ID</th><th class="border">Student Email</th></tr>';
    for (i = 0; i < studentData.length; i++) {
        var studentNumber = studentData[i].studentid;
        var studentEmail = studentData[i].emailaddress;
        tableData += '<tr><td class="border">' + studentNumber + '</td><td class="border">' + studentEmail + '</td></tr>';
    }  
    document.getElementById("studentTable").innerHTML = tableData;
}
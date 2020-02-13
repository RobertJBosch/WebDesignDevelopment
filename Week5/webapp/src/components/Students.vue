<template>
  <div class="students">
    <a></a>
    <h1>Student Page</h1>
    <h3>Student Data</h3>
    <table id='studentTable'>  
            <thead>
                <tr>
                    <th class="border">Student ID Number</th>
                    <th class="border">Email Address</th>
                </tr>
            </thead>       
            <tbody>
                <tr v-for="student in students" v-bind:key="student">
                    <td class="border">{{ student.studentid }}</td>
                    <td class="border">{{ student.emailaddress }}</td>                
                </tr>
            </tbody>
        </table>
  </div>
</template>

<script>
export default {
    name: 'Students',
    mounted() {
        this.students = getStudents();
    },
    data () {
        return {
            students: []
        }
    }
}

function getStudents() {
    return JSON.parse(studentData);
}

var studentData = '[{"studentid":123456, "emailaddress":"thisisanemailaddress@email.com"},' +
   '{"studentid":789123, "emailaddress": "thisisanotheremail@gmail.com"},' +
   '{"studentid":456789, "emailaddress": "yetanotherone@hemail.com"}]'
  
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
.datatable {
    width: 50%;
    padding: 6px;
    border-collapse: collapse;
}
th.border {
    border: 1px solid black;
    font-family: 'Trebuchet MS', 'Lucida Sans Unicode', 'Lucida Grande', 'Lucida Sans', Arial, sans-serif;
    background-color: red;
    color: green;
    text-align: center;
    padding: 10px;
}
td.border {
    border: 1px solid black;
    text-align: left;
    padding: 10px;
}
th {
    text-align: center;
    padding: 10px;
}
td {
    text-align: left;
    padding: 10px;
}
h3 {
    text-align: left;
}
</style>

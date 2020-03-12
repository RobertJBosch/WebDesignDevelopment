<template>
  <div class="instructors">
    <a></a>
    <h1>Instructor Page</h1>
    <h3>Instructor Data</h3>
    <table id="instructorTable">
      <thead>
        <tr>
          <th class="border">First Name</th>
          <th class="border">Middle Initial</th>
          <th class="border">Last Name</th>
        </tr>
      </thead>
      <tbody>
        <tr v-for="instructor in instructors" v-bind:key="instructor">
          <td class="border">{{ instructor.firstname }}</td>
          <td class="border">{{ instructor.middleinitial }}</td>
          <td class="border">{{ instructor.lastname }}</td>
        </tr>
      </tbody>
    </table>
  </div>
</template>

<script>
export default {
  name: "Instructors",
  mounted() {
    this.instructors = getInstructors();
  },
  data() {
    return {
      instructors: []
    };
  }
};

function getInstructors() {
  return JSON.parse(instructorData);
}
var instructorData =
  '[{"firstname":"Bill Nye", "middleinitial":"T", "lastname":"Science Guy"},' +
  '{"firstname":"Steve", "middleinitial":"R", "lastname":"Irwin"},' +
  '{"firstname":"Nathan", "middleinitial":"C", "lastname":"Smurthwaite"}]';
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
  font-family: "Trebuchet MS", "Lucida Sans Unicode", "Lucida Grande",
    "Lucida Sans", Arial, sans-serif;
  background-color: red;
  color: green;
  text-align: center;
  padding: 10px;
}
td.border {
  border: 1px solid black;
  text-align: left;
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

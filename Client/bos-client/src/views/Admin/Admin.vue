

<template>

    <DataTable :value="productList" tableStyle="min-width: 50rem">
        <Column field="name" header="Name"></Column>
        <Column field="price" header="Price"></Column>

    </DataTable>
    



</template>

<script lang="ts" src="./Admin.ts"/>


<style scoped>
ul,
li {
  margin-left: 0;
  padding-left: 0;
}
</style>
<template>
  <div>
    <div class="board">
      <!-- Card -->
      <div v-for="note in notes">
        <div class="card floating-card note-card">
          <div class="card-header">
            <div class="container">
              <div class="row">
                <div class="col">
                  <p class="card-title note-title">{{ note.title }}</p>
                </div>
                <div class="col">
                  <a href="#" title="Remove note">
                    <img class="note-icon" width="25" height="25" src="../assets/icon-trash.png" data-target="#noteEdit" />
                  </a>
                  <a href="#" title="Edit note">
                    <img class="note-icon" width="25" height="25" src="../assets/icon-edit.png" data-target="#noteEdit" />
                  </a>
                </div>
              </div>
            </div>
          </div>
          <div>
            <p class="card-body" v-html="note.content"></p>
          </div>
        </div>
      </div>
    </div>

    <!-- Edit button -->
    <button type="button" class="btn-icon add-btn" @click="displayEditNewNoteModal" title="New note">
      <img width="60" height="60" src="../assets/icon-plus.png" />
    </button>
    
    <!-- Edit modal -->
    <div>
      <b-modal ref="editModal" hide-footer hide-header-close title="Edit note">
        <div class="d-block">
          <!-- Input of note title -->
          <div class="input-group mb-3">
            <div class="input-group-prepend">
              <span class="input-group-text">Title</span>
            </div>
            <input type="text" class="form-control" placeholder="title">
          </div>
          <!-- Input of note content -->
          <div class="input-group mb-3">
            <div class="input-group-prepend">
              <span class="input-group-text">Content</span>
            </div>
            <textarea class="form-control" aria-label="With textarea"></textarea>
          </div>
        </div>          
        <b-button class="mt-3" block @click="closeEditModal">Cancel</b-button>
        <b-button class="mt-3 btn-success" style="margin-left: 0.5rem" block @click="saveEditModal">Save</b-button>
      </b-modal>
    </div>

  </div>  
</template>

<script>
export default {
  name: 'Notes',
  data: function () {
    return {
      notes: null,
      isNew: false,
      currentNote: new Object(),
    }
  },
  methods: {
    displayEditNewNoteModal() {
      this.isNew = true;

      this.currentNote = new Object();
      this.currentNote.id = null;
      this.currentNote.title = null;
      this.currentNote.content = null;
      
      this.$refs['editModal'].show()
    },
    closeEditModal() {
      this.$refs['editModal'].hide()
    },
    saveEditModal() {
      this.$refs['editModal'].hide()
    },
  },
  created: async function() {
    const response = await fetch('/note', {
      method: 'GET',
      headers: {
        'Content-Type': 'application/json'
      }
    });

    this.notes = await response.json();

    this.notes.forEach(item => {
      item.content = item.content.replace(/(?:\r\n|\r|\n)/g, " <br> ");
    });
  }
}
</script>

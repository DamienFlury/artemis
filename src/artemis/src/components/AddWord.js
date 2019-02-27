import React, { useState, useRef } from 'react'
import { Grid, TextField, Button } from '@material-ui/core'

const AddWord = ({ onClick }) => {
  const [frontside, setFrontside] = useState('')
  const [backside, setBackside] = useState('')

  const frontsideInput = useRef(null)

  const handleSubmit = event => {
    event.preventDefault()
    onClick(frontside, backside)
    setFrontside('')
    setBackside('')
    frontsideInput.current.focus()
}

  return (
    <form onSubmit={handleSubmit}>
      <Grid container spacing={32} style={{ padding: 20 }}>
        <Grid item sm={5} xs={12}>
          <TextField
            label="Frontside"
            value={frontside}
            onChange={e => setFrontside(e.target.value)}
            inputRef={frontsideInput}
            fullWidth
          />
        </Grid>
        <Grid item sm={5} xs={12}>
          <TextField
            label="Backside"
            value={backside}
            onChange={e => setBackside(e.target.value)}
            fullWidth
          />
        </Grid>
        <Grid item sm={2} xs={12}>
          <Button variant="contained" color="secondary" type="submit" fullWidth>
            Add
          </Button>
        </Grid>
      </Grid>
    </form>
  )
}

export default AddWord

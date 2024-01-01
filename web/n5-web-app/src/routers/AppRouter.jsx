import React from 'react'
import { Route, Routes } from 'react-router-dom'
import { Navbar } from '../components/Navbar'
import { CreatePermissionScreen } from '../components/CreatePermissionScreen'
import { ListPermissionScreen } from '../components/ListPermissionScreen'
import { ModifyPermissionScreen } from '../components/ModifyPermissionScreen'

import '../index.css'

export const AppRouter = () => {
  return (
    <div>
      <Navbar />
      <div className='container'>
        <Routes>
          <Route path='/' element={ <ListPermissionScreen />} />
          <Route path='/permissions' element={ <ListPermissionScreen />} />
          <Route path='/create' element={ <CreatePermissionScreen />} />
          <Route path='/permission/:permissionId' element={ <ModifyPermissionScreen /> } />
        </Routes>
      </div>
    </div>
  )
}

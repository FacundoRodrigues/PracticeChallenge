import React from 'react'
import { RouterProvider, createBrowserRouter } from 'react-router-dom'
import { AppRouter } from './routers/AppRouter'
import { CreatePermissionScreen } from './components/CreatePermissionScreen'
import { ListPermissionScreen } from './components/ListPermissionScreen'
import { ModifyPermissionScreen } from './components/ModifyPermissionScreen'
import { AboutScreen } from './components/AboutScreen'

const router = createBrowserRouter([
  {
    path: '/',
    element: <AppRouter />,
    children: [
      {
        path: '/permissions',
        element: <ListPermissionScreen />
      },
      {
        path: '/create',
        element: <CreatePermissionScreen />
      },
      {
        path: '/permission/:permissionId',
        element: <ModifyPermissionScreen />
      },
      {
        path: '/about',
        element: <AboutScreen />
      }
    ]

  }
])

export const PermissionsApp = () => {
  return (
    <RouterProvider router={router} />
  )
}
